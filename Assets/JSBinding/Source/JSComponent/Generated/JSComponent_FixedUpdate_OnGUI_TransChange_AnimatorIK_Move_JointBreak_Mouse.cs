﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_FixedUpdate_OnGUI_TransChange_AnimatorIK_Move_JointBreak_Mouse : JSComponent
{
    int idFixedUpdate;
    int idOnGUI;
    int idOnTransformChildrenChanged;
    int idOnTransformParentChanged;
    int idOnAnimatorIK;
    int idOnAnimatorMove;
    int idOnJointBreak;
    int idOnMouseDown;
    int idOnMouseDrag;
    int idOnMouseEnter;
    int idOnMouseExit;
    int idOnMouseOver;
    int idOnMouseUp;
    int idOnMouseUpAsButton;

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idFixedUpdate = JSApi.getObjFunction(jsObjID, "FixedUpdate");
        idOnGUI = JSApi.getObjFunction(jsObjID, "OnGUI");
        idOnTransformChildrenChanged = JSApi.getObjFunction(jsObjID, "OnTransformChildrenChanged");
        idOnTransformParentChanged = JSApi.getObjFunction(jsObjID, "OnTransformParentChanged");
        idOnAnimatorIK = JSApi.getObjFunction(jsObjID, "OnAnimatorIK");
        idOnAnimatorMove = JSApi.getObjFunction(jsObjID, "OnAnimatorMove");
        idOnJointBreak = JSApi.getObjFunction(jsObjID, "OnJointBreak");
        idOnMouseDown = JSApi.getObjFunction(jsObjID, "OnMouseDown");
        idOnMouseDrag = JSApi.getObjFunction(jsObjID, "OnMouseDrag");
        idOnMouseEnter = JSApi.getObjFunction(jsObjID, "OnMouseEnter");
        idOnMouseExit = JSApi.getObjFunction(jsObjID, "OnMouseExit");
        idOnMouseOver = JSApi.getObjFunction(jsObjID, "OnMouseOver");
        idOnMouseUp = JSApi.getObjFunction(jsObjID, "OnMouseUp");
        idOnMouseUpAsButton = JSApi.getObjFunction(jsObjID, "OnMouseUpAsButton");
    }

    void FixedUpdate()
    {
        callIfExist(idFixedUpdate);
    }
    void OnGUI()
    {
        callIfExist(idOnGUI);
    }
    void OnTransformChildrenChanged()
    {
        callIfExist(idOnTransformChildrenChanged);
    }
    void OnTransformParentChanged()
    {
        callIfExist(idOnTransformParentChanged);
    }
    void OnAnimatorIK(int layerIndex)
    {
        callIfExist(idOnAnimatorIK, layerIndex);
    }
    void OnAnimatorMove()
    {
        callIfExist(idOnAnimatorMove);
    }
    void OnJointBreak(float breakForce)
    {
        callIfExist(idOnJointBreak, breakForce);
    }
    void OnMouseDown()
    {
        callIfExist(idOnMouseDown);
    }
    void OnMouseDrag()
    {
        callIfExist(idOnMouseDrag);
    }
    void OnMouseEnter()
    {
        callIfExist(idOnMouseEnter);
    }
    void OnMouseExit()
    {
        callIfExist(idOnMouseExit);
    }
    void OnMouseOver()
    {
        callIfExist(idOnMouseOver);
    }
    void OnMouseUp()
    {
        callIfExist(idOnMouseUp);
    }
    void OnMouseUpAsButton()
    {
        callIfExist(idOnMouseUpAsButton);
    }

}