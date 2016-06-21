
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


using jsval = JSApi.jsval;

public class HttpManagerGenerated
{

////////////////////// HttpManager ///////////////////////////////////////
// constructors

static bool HttpManager_HttpManager1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new HttpManager());
    }

    return true;
}

// fields

// properties
static void HttpManager_Instance(JSVCall vc)
{
        var result = HttpManager.Instance;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}

// methods
public static Action<System.String> HttpManager_StartHttpGet_GetDelegate_member0_arg1(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    Action<System.String> action = (Action<System.String>)JSMgr.getJSFunCSDelegateRel(objFunction.jsObjID); 
    if (action != null)
        return action;

    action = (obj) => 
    {
        JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, obj);
    };
    JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    return action;
}

static bool HttpManager_StartHttpGet__String__ActionT1_String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        Action<System.String> arg1 = JSDataExchangeMgr.GetJSArg<Action<System.String>>(()=>{
    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
        return HttpManager_StartHttpGet_GetDelegate_member0_arg1(JSApi.getFunctionS((int)JSApi.GetType.Arg));
    else
        return (Action<System.String>)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
})
;
        ((HttpManager)vc.csObj).StartHttpGet(arg0, arg1);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(HttpManager);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        HttpManager_Instance,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(HttpManager_HttpManager1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(HttpManager_StartHttpGet__String__ActionT1_String, "StartHttpGet"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
