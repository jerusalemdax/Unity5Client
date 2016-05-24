﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


using jsval = JSApi.jsval;

public class UnityEngine_BehaviourGenerated
{

////////////////////// Behaviour ///////////////////////////////////////
// constructors

static bool Behaviour_Behaviour1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Behaviour());
    }

    return true;
}

// fields

// properties
static void Behaviour_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Behaviour _this = (UnityEngine.Behaviour)vc.csObj;
        var result = _this.enabled;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Behaviour _this = (UnityEngine.Behaviour)vc.csObj;
        _this.enabled = arg0;
    }
}
static void Behaviour_isActiveAndEnabled(JSVCall vc)
{
        UnityEngine.Behaviour _this = (UnityEngine.Behaviour)vc.csObj;
        var result = _this.isActiveAndEnabled;
        JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Behaviour);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Behaviour_enabled,
        Behaviour_isActiveAndEnabled,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Behaviour_Behaviour1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
