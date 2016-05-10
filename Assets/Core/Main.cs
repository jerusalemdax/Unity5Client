using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

public class Main : MonoBehaviour
{
    private static Main Instance;
    private CLRSharp.CLRSharp_Environment _env;
    private CLRSharp.ThreadContext _context;
    private CLRSharp.IMethod _startMethod;
    private CLRSharp.IMethod _updateMethod;
    private CLRSharp.IMethod _onDestroyMethod;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Debug.Log("Unity version: " + Application.unityVersion);
        Debug.Log("Platform: " + Application.platform);

        _env = new CLRSharp.CLRSharp_Environment(new Logger());

        ResourceManager.Instance.LoadResourceBytes("Scripts.dll", bytes =>
        {
            MemoryStream msDll = new MemoryStream(bytes);
            _env.LoadModule(msDll);
            _context = new CLRSharp.ThreadContext(_env);
            CLRSharp.ICLRType wantType = _env.GetType("LMain");
            _startMethod = wantType.GetMethod("Start", CLRSharp.MethodParamList.constEmpty());
            _updateMethod = wantType.GetMethod("Update", CLRSharp.MethodParamList.constEmpty());
            _onDestroyMethod = wantType.GetMethod("OnDestroy", CLRSharp.MethodParamList.constEmpty());
            _startMethod.Invoke(_context, null, null);
        });
    }

    void Update()
    {
        if (_updateMethod != null)
        {
            _updateMethod.Invoke(_context, null, null);
        }
    }

    void OnDestroy()
    {
        if (_onDestroyMethod != null)
        {
            _onDestroyMethod.Invoke(_context, null, null);
        }
        Debug.Log("Main OnDestroy");
    }

    public static Coroutine StartCoroutineFunc(IEnumerator func)
    {
        return Instance.StartCoroutine(func);
    }

    public class Logger : CLRSharp.ICLRSharp_Logger//实现L#的LOG接口
    {
        public void Log(string str)
        {
            Debug.Log(str);
        }

        public void Log_Error(string str)
        {
            Debug.LogError(str);
        }

        public void Log_Warning(string str)
        {
            Debug.LogWarning(str);
        }
    }
}