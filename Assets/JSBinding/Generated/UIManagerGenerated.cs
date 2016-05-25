
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


using jsval = JSApi.jsval;

public class UIManagerGenerated
{

////////////////////// UIManager ///////////////////////////////////////
// constructors

static bool UIManager_UIManager1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UIManager());
    }

    return true;
}

// fields

// properties
static void UIManager_Instance(JSVCall vc)
{
        var result = UIManager.Instance;
        JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}

// methods

static bool UIManager_Init(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UIManager)vc.csObj).Init();
    }

    return true;
}

static bool UIManager_ShowPanel__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        ((UIManager)vc.csObj).ShowPanel(arg0);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UIManager);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        UIManager_Instance,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(UIManager_UIManager1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(UIManager_Init, "Init"),
        new JSMgr.MethodCallBackInfo(UIManager_ShowPanel__String, "ShowPanel"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
