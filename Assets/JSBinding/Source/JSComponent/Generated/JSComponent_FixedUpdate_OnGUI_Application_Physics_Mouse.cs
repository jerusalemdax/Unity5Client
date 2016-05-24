﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_FixedUpdate_OnGUI_Application_Physics_Mouse : JSComponent
{
    int idFixedUpdate;
    int idOnGUI;
    int idOnApplicationFocus;
    int idOnApplicationPause;
    int idOnApplicationQuit;
    int idOnAudioFilterRead;
    int idOnLevelWasLoaded;
    int idOnParticleCollision;
    int idOnCollisionEnter;
    int idOnCollisionEnter2D;
    int idOnCollisionExit;
    int idOnCollisionExit2D;
    int idOnCollisionStay;
    int idOnCollisionStay2D;
    int idOnTriggerEnter;
    int idOnTriggerEnter2D;
    int idOnTriggerExit;
    int idOnTriggerExit2D;
    int idOnTriggerStay;
    int idOnTriggerStay2D;
    int idOnControllerColliderHit;
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
        idOnApplicationFocus = JSApi.getObjFunction(jsObjID, "OnApplicationFocus");
        idOnApplicationPause = JSApi.getObjFunction(jsObjID, "OnApplicationPause");
        idOnApplicationQuit = JSApi.getObjFunction(jsObjID, "OnApplicationQuit");
        idOnAudioFilterRead = JSApi.getObjFunction(jsObjID, "OnAudioFilterRead");
        idOnLevelWasLoaded = JSApi.getObjFunction(jsObjID, "OnLevelWasLoaded");
        idOnParticleCollision = JSApi.getObjFunction(jsObjID, "OnParticleCollision");
        idOnCollisionEnter = JSApi.getObjFunction(jsObjID, "OnCollisionEnter");
        idOnCollisionEnter2D = JSApi.getObjFunction(jsObjID, "OnCollisionEnter2D");
        idOnCollisionExit = JSApi.getObjFunction(jsObjID, "OnCollisionExit");
        idOnCollisionExit2D = JSApi.getObjFunction(jsObjID, "OnCollisionExit2D");
        idOnCollisionStay = JSApi.getObjFunction(jsObjID, "OnCollisionStay");
        idOnCollisionStay2D = JSApi.getObjFunction(jsObjID, "OnCollisionStay2D");
        idOnTriggerEnter = JSApi.getObjFunction(jsObjID, "OnTriggerEnter");
        idOnTriggerEnter2D = JSApi.getObjFunction(jsObjID, "OnTriggerEnter2D");
        idOnTriggerExit = JSApi.getObjFunction(jsObjID, "OnTriggerExit");
        idOnTriggerExit2D = JSApi.getObjFunction(jsObjID, "OnTriggerExit2D");
        idOnTriggerStay = JSApi.getObjFunction(jsObjID, "OnTriggerStay");
        idOnTriggerStay2D = JSApi.getObjFunction(jsObjID, "OnTriggerStay2D");
        idOnControllerColliderHit = JSApi.getObjFunction(jsObjID, "OnControllerColliderHit");
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
    void OnApplicationFocus(bool focusStatus)
    {
        callIfExist(idOnApplicationFocus, focusStatus);
    }
    void OnApplicationPause(bool pauseStatus)
    {
        callIfExist(idOnApplicationPause, pauseStatus);
    }
    void OnApplicationQuit()
    {
        callIfExist(idOnApplicationQuit);
    }
    void OnAudioFilterRead(float[] data, int channels)
    {
        callIfExist(idOnAudioFilterRead, data, channels);
    }
    void OnLevelWasLoaded(int level)
    {
        callIfExist(idOnLevelWasLoaded, level);
    }
    void OnParticleCollision(GameObject other)
    {
        callIfExist(idOnParticleCollision, other);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        callIfExist(idOnCollisionEnter, collisionInfo);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        callIfExist(idOnCollisionEnter2D, coll);
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        callIfExist(idOnCollisionExit, collisionInfo);
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        callIfExist(idOnCollisionExit2D, coll);
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        callIfExist(idOnCollisionStay, collisionInfo);
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        callIfExist(idOnCollisionStay2D, coll);
    }
    void OnTriggerEnter(Collider other)
    {
        callIfExist(idOnTriggerEnter, other);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        callIfExist(idOnTriggerEnter2D, other);
    }
    void OnTriggerExit(Collider other)
    {
        callIfExist(idOnTriggerExit, other);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        callIfExist(idOnTriggerExit2D, other);
    }
    void OnTriggerStay(Collider other)
    {
        callIfExist(idOnTriggerStay, other);
    }
    void OnTriggerStay2D(Collider2D other)
    {
        callIfExist(idOnTriggerStay2D, other);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        callIfExist(idOnControllerColliderHit, hit);
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