﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_FixedUpdate_OnGUI_Enable_Visible_Application_AnimatorIK_Move_JointBreak_Physics_Server_Mouse : JSComponent
{
    int idFixedUpdate;
    int idOnGUI;
    int idOnDisable;
    int idOnEnable;
    int idOnBecameInvisible;
    int idOnBecameVisible;
    int idOnApplicationFocus;
    int idOnApplicationPause;
    int idOnApplicationQuit;
    int idOnAudioFilterRead;
    int idOnLevelWasLoaded;
    int idOnAnimatorIK;
    int idOnAnimatorMove;
    int idOnJointBreak;
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
    int idOnConnectedToServer;
    int idOnDisconnectedFromServer;
    int idOnFailedToConnect;
    int idOnFailedToConnectToMasterServer;
    int idOnMasterServerEvent;
    int idOnNetworkInstantiate;
    int idOnPlayerConnected;
    int idOnPlayerDisconnected;
    int idOnSerializeNetworkView;
    int idOnServerInitialized;
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
        idOnDisable = JSApi.getObjFunction(jsObjID, "OnDisable");
        idOnEnable = JSApi.getObjFunction(jsObjID, "OnEnable");
        idOnBecameInvisible = JSApi.getObjFunction(jsObjID, "OnBecameInvisible");
        idOnBecameVisible = JSApi.getObjFunction(jsObjID, "OnBecameVisible");
        idOnApplicationFocus = JSApi.getObjFunction(jsObjID, "OnApplicationFocus");
        idOnApplicationPause = JSApi.getObjFunction(jsObjID, "OnApplicationPause");
        idOnApplicationQuit = JSApi.getObjFunction(jsObjID, "OnApplicationQuit");
        idOnAudioFilterRead = JSApi.getObjFunction(jsObjID, "OnAudioFilterRead");
        idOnLevelWasLoaded = JSApi.getObjFunction(jsObjID, "OnLevelWasLoaded");
        idOnAnimatorIK = JSApi.getObjFunction(jsObjID, "OnAnimatorIK");
        idOnAnimatorMove = JSApi.getObjFunction(jsObjID, "OnAnimatorMove");
        idOnJointBreak = JSApi.getObjFunction(jsObjID, "OnJointBreak");
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
        idOnConnectedToServer = JSApi.getObjFunction(jsObjID, "OnConnectedToServer");
        idOnDisconnectedFromServer = JSApi.getObjFunction(jsObjID, "OnDisconnectedFromServer");
        idOnFailedToConnect = JSApi.getObjFunction(jsObjID, "OnFailedToConnect");
        idOnFailedToConnectToMasterServer = JSApi.getObjFunction(jsObjID, "OnFailedToConnectToMasterServer");
        idOnMasterServerEvent = JSApi.getObjFunction(jsObjID, "OnMasterServerEvent");
        idOnNetworkInstantiate = JSApi.getObjFunction(jsObjID, "OnNetworkInstantiate");
        idOnPlayerConnected = JSApi.getObjFunction(jsObjID, "OnPlayerConnected");
        idOnPlayerDisconnected = JSApi.getObjFunction(jsObjID, "OnPlayerDisconnected");
        idOnSerializeNetworkView = JSApi.getObjFunction(jsObjID, "OnSerializeNetworkView");
        idOnServerInitialized = JSApi.getObjFunction(jsObjID, "OnServerInitialized");
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
    void OnConnectedToServer()
    {
        callIfExist(idOnConnectedToServer);
    }
    void OnDisconnectedFromServer(NetworkDisconnection info)
    {
        callIfExist(idOnDisconnectedFromServer, info);
    }
    void OnFailedToConnect(NetworkConnectionError error)
    {
        callIfExist(idOnFailedToConnect, error);
    }
    void OnFailedToConnectToMasterServer(NetworkConnectionError info)
    {
        callIfExist(idOnFailedToConnectToMasterServer, info);
    }
    void OnMasterServerEvent(MasterServerEvent msEvent)
    {
        callIfExist(idOnMasterServerEvent, msEvent);
    }
    void OnNetworkInstantiate(NetworkMessageInfo info)
    {
        callIfExist(idOnNetworkInstantiate, info);
    }
    void OnPlayerConnected(NetworkPlayer player)
    {
        callIfExist(idOnPlayerConnected, player);
    }
    void OnPlayerDisconnected(NetworkPlayer player)
    {
        callIfExist(idOnPlayerDisconnected, player);
    }
    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
    {
        callIfExist(idOnSerializeNetworkView, stream, info);
    }
    void OnServerInitialized()
    {
        callIfExist(idOnServerInitialized);
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