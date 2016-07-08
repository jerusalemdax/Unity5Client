using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// JSComponent
/// A class redirect event functions (Awake, Start, Update, etc.) to JavaScript
/// Support serializations
/// </summary>
public class JSComponent : JSSerializer
{
    [HideInInspector]
    [NonSerialized]
    protected int JsObjID;

    private Dictionary<string, int> _classDic = new Dictionary<string, int>();
    private Dictionary<int, Dictionary<string, int>> _funcDic = new Dictionary<int, Dictionary<string, int>>();
    private int _idStart;
    private int _idOnDestroy;

    /// <summary>
    /// Initializes the member function.
    /// </summary>
    protected virtual void InitMemberFunction()
    {
        _idStart = JSApi.getObjFunction(JsObjID, "Start");
        _idOnDestroy = JSApi.getObjFunction(JsObjID, "OnDestroy");
    }

    private int _jsState;

    private bool JsSuccess
    {
        get
        {
            return _jsState == 1;
        }
        set
        {
            if (value) _jsState = 1;
        }
    }

    public bool JsFail
    {
        private get
        {
            return _jsState == 2;
        }
        set
        {
            _jsState = value ? 2 : 0;
        }
    }

    protected void CallIfExist(int funID, params object[] args)
    {
        CallIfExist(JsObjID, funID, args);
    }

    protected void CallIfExist(int objID, int funID, params object[] args)
    {
        if (funID > 0)
        {
            JSMgr.vCall.CallJSFunctionValue(objID, funID, args);
        }
        else
        {
            Debug.LogWarning("Not find function: " + funID);
        }
    }

    private void InitJs()
    {
        if (JsFail || JsSuccess) return;

        if (string.IsNullOrEmpty(jsClassName))
        {
            JsFail = true;
            return;
        }

        // ATTENSION
        // cannot use createJSClassObject here
        // because we have to call ctor, to run initialization code
        // this object will not have finalizeOp
        JsObjID = JSApi.newJSClassObject(jsClassName);
        JSApi.setTraceS(JsObjID, true);
        if (JsObjID == 0)
        {
            Debug.LogError("New MonoBehaviour \"" + jsClassName + "\" failed. Did you forget to export that class?");
            JsFail = true;
            return;
        }
        JSMgr.addJSCSRel(JsObjID, this);
        InitMemberFunction();
        JsSuccess = true;
    }

    //
    // 有几个事情要做
    // A) initJS()
    // B) initSerializedData(jsObjID)
    // C) callIfExist(idAwake);
    //
    // 不同时候要做的事情，假设有2个类 X 和 Y
    // 1) 假设 X 类不被其他类所引用，则 X 类 Awake 时：A + B + C
    // 2) 在 X 类 initSerializedData 时发现引用了 Y 类，而 Y 类的 Awake 还没有被调用，那么会马上调用 Y 类的 A（看 GetJSObjID 函数），之后 Y 类的 Awake 里：B + C
    //    看 JSSerializer.GetGameObjectMonoBehaviourJSObj 函数
    //    为什么第1步只调用Y的A，而不调B？因为那时候X类正在处理序列化，不想中间又穿插Y的序列化处理，也用不到
    // 3) 在 AddComponent<X>() 时，我们知道他会调用 Awake()，但是此时由于 jsClassName 未被设置，所以会 jsFail=true，但紧接着我们又设置 jsFail=false，然后调用 init(true) 和 callAwake()，做的事情也是 A + B + C
    //    看 Components.cs 里的 GameObject_AddComponentT1 函数
    // 4) 在 GetComponent<X>() 时，如果 X 的 Awake() 还未调用，我们会调用 X 的 init(true)，他做了 A + B，之后 X 的 Awake() 再做 C
    //    看 Components.cs 里的 help_searchAndRetCom 和 help_searchAndRetComs 函数
    //
    //
    // 总结：以上那么多分类，做的事情其实就是，当一个类X要在Awake时去获取Y类组件，甚至访问Y类成员，如果此时Y类的Awake还没有调用，此时会得到undefined，那么我们只好先初始化一下Y类的JS对象。
    //
    public void Init(bool callSerialize)
    {
        if (!JSEngine.initSuccess && !JSEngine.initFail)
        {
            JSEngine.FirstInit();
        }
        if (!JSEngine.initSuccess)
        {
            return;
        }

        InitJs();

        if (JsSuccess && callSerialize && !DataSerialized)
        {
            initSerializedData(JsObjID);
        }
    }

	public override void initSerializedData(int jsObjID)
	{
		if (DataSerialized)
			return;
		base.initSerializedData(jsObjID);

		for (var i = 0; waitSerialize != null && i < waitSerialize.Count; i++)
		{
			waitSerialize[i].initSerializedData(waitSerialize[i].JsObjID);
		}
		waitSerialize = null;
	}

    /// <summary>
    /// get javascript object id of this JSComponent.
    /// jsObjID may == 0 when this function is called, because other scripts refer to this JSComponent.
    /// in this case, we call initJS() for this JSComponent immediately.
    /// </summary>
    /// <returns></returns>
    ///
    public int GetJsObjID(bool callSerialize)
    {
        if (JsObjID == 0)
        {
            Init(callSerialize);
        }
        return JsObjID;
    }

    IEnumerator Start()
    {
#if UNITY_EDITOR
        while (JSEngine.initSuccess == false)
        {
            yield return null;
        }
#endif
        Init(true);
        CallIfExist(_idStart);
        yield return null;
    }

    void OnDestroy()
    {
        if (!JSMgr.IsShutDown)
        {
            CallIfExist(_idOnDestroy);
        }

        if (JsSuccess)
        {
            JSMgr.removeJSCSRel(JsObjID);
        }

        if (JSMgr.IsShutDown)
        {
            return;
        }

        if (JsSuccess)
        {
            JSApi.setTraceS(JsObjID, false);
            JSApi.removeByID(JsObjID);
        }
    }

    public void Call(string function)
    {
        string[] strs = function.Split('.');
        string className = strs[0];
        string func  = strs[1];
        int objID;

        if (!_classDic.ContainsKey(className))
        {
            objID = JSApi.newJSClassObject(className);
            if (objID == 0)
            {
                Debug.LogError("New MonoBehaviour \"" + className + "\" failed. Did you forget to export that class?");
                return;
            }
            _classDic.Add(className, objID);
            _funcDic.Add(objID, new Dictionary<string, int>());
        }
        else
        {
            objID = _classDic[className];
        }

        int funcID;
        if (!_funcDic[objID].ContainsKey(func))
        {
            funcID = JSApi.getObjFunction(objID, func);
            if (funcID <= 0)
            {
                Debug.LogError("Not find function " + className + "." + func);
                return;
            }
            _funcDic[objID].Add(func, funcID);
        }
        else
        {
            funcID = _funcDic[objID][func];
        }
        CallIfExist(objID, funcID);
    }
}
