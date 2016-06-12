
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


using jsval = JSApi.jsval;

public class SceneManagerExGenerated
{

////////////////////// SceneManagerEx ///////////////////////////////////////
// constructors

static bool SceneManagerEx_SceneManagerEx1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new SceneManagerEx());
    }

    return true;
}

// fields

// properties
static void SceneManagerEx_Instance(JSVCall vc)
{
        var result = SceneManagerEx.Instance;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}

// methods

static bool SceneManagerEx_Init(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((SceneManagerEx)vc.csObj).Init();
    }

    return true;
}

static bool SceneManagerEx_ShowScene__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((SceneManagerEx)vc.csObj).ShowScene(arg0);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(SceneManagerEx);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        SceneManagerEx_Instance,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(SceneManagerEx_SceneManagerEx1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(SceneManagerEx_Init, "Init"),
        new JSMgr.MethodCallBackInfo(SceneManagerEx_ShowScene__String, "ShowScene"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
