﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_Update_Enable_Visible_Render : JSComponent
{
    int idUpdate;
    int idLateUpdate;
    int idOnDisable;
    int idOnEnable;
    int idOnBecameInvisible;
    int idOnBecameVisible;
    int idOnPostRender;
    int idOnPreCull;
    int idOnPreRender;
    int idOnRenderImage;
    int idOnRenderObject;
    int idOnWillRenderObject;

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idUpdate = JSApi.getObjFunction(jsObjID, "Update");
        idLateUpdate = JSApi.getObjFunction(jsObjID, "LateUpdate");
        idOnDisable = JSApi.getObjFunction(jsObjID, "OnDisable");
        idOnEnable = JSApi.getObjFunction(jsObjID, "OnEnable");
        idOnBecameInvisible = JSApi.getObjFunction(jsObjID, "OnBecameInvisible");
        idOnBecameVisible = JSApi.getObjFunction(jsObjID, "OnBecameVisible");
        idOnPostRender = JSApi.getObjFunction(jsObjID, "OnPostRender");
        idOnPreCull = JSApi.getObjFunction(jsObjID, "OnPreCull");
        idOnPreRender = JSApi.getObjFunction(jsObjID, "OnPreRender");
        idOnRenderImage = JSApi.getObjFunction(jsObjID, "OnRenderImage");
        idOnRenderObject = JSApi.getObjFunction(jsObjID, "OnRenderObject");
        idOnWillRenderObject = JSApi.getObjFunction(jsObjID, "OnWillRenderObject");
    }

    void Update()
    {
        callIfExist(idUpdate);
    }
    void LateUpdate()
    {
        callIfExist(idLateUpdate);
    }
    void OnDisable()
    {
        callIfExist(idOnDisable);
    }
    void OnEnable()
    {
        callIfExist(idOnEnable);
    }
    void OnBecameInvisible()
    {
        callIfExist(idOnBecameInvisible);
    }
    void OnBecameVisible()
    {
        callIfExist(idOnBecameVisible);
    }
    void OnPostRender()
    {
        callIfExist(idOnPostRender);
    }
    void OnPreCull()
    {
        callIfExist(idOnPreCull);
    }
    void OnPreRender()
    {
        callIfExist(idOnPreRender);
    }
    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        callIfExist(idOnRenderImage, src, dest);
    }
    void OnRenderObject()
    {
        callIfExist(idOnRenderObject);
    }
    void OnWillRenderObject()
    {
        callIfExist(idOnWillRenderObject);
    }

}