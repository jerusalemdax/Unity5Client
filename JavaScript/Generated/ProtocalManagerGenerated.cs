
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


using jsval = JSApi.jsval;

public class ProtocalManagerGenerated
{

////////////////////// ProtocalManager ///////////////////////////////////////
// constructors

static bool ProtocalManager_ProtocalManager1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new ProtocalManager());
    }

    return true;
}

// fields

// properties
static void ProtocalManager_Instance(JSVCall vc)
{
        var result = ProtocalManager.Instance;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}

// methods

static bool ProtocalManager_Init(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((ProtocalManager)vc.csObj).Init();
    }

    return true;
}
public static Action<SimpleJson.JsonObject> ProtocalManager_Request_GetDelegate_member1_arg2(CSRepresentedObject objFunction)
{
    if (objFunction == null || objFunction.jsObjID == 0)
    {
        return null;
    }
    Action<SimpleJson.JsonObject> action = (Action<SimpleJson.JsonObject>)JSMgr.getJSFunCSDelegateRel(objFunction.jsObjID); 
    if (action != null)
        return action;

    action = (obj) => 
    {
        JSMgr.vCall.CallJSFunctionValue(0, objFunction.jsObjID, obj);
    };
    JSMgr.addJSFunCSDelegateRel(objFunction.jsObjID, action);
    return action;
}

static bool ProtocalManager_Request__String__JsonObject__ActionT1_JsonObject(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        SimpleJson.JsonObject arg1 = (SimpleJson.JsonObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        Action<SimpleJson.JsonObject> arg2 = JSDataExchangeMgr.GetJSArg<Action<SimpleJson.JsonObject>>(()=>{
    if (JSApi.isFunctionS((int)JSApi.GetType.Arg))
        return ProtocalManager_Request_GetDelegate_member1_arg2(JSApi.getFunctionS((int)JSApi.GetType.Arg));
    else
        return (Action<SimpleJson.JsonObject>)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
})
;
        ((ProtocalManager)vc.csObj).Request(arg0, arg1, arg2);
    }

    return true;
}

static bool ProtocalManager_Update(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((ProtocalManager)vc.csObj).Update();
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(ProtocalManager);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        ProtocalManager_Instance,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ProtocalManager_ProtocalManager1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ProtocalManager_Init, "Init"),
        new JSMgr.MethodCallBackInfo(ProtocalManager_Request__String__JsonObject__ActionT1_JsonObject, "Request"),
        new JSMgr.MethodCallBackInfo(ProtocalManager_Update, "Update"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
