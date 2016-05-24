﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_Enable_Visible_Server : JSComponent
{
    int idOnDisable;
    int idOnEnable;
    int idOnBecameInvisible;
    int idOnBecameVisible;
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

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idOnDisable = JSApi.getObjFunction(jsObjID, "OnDisable");
        idOnEnable = JSApi.getObjFunction(jsObjID, "OnEnable");
        idOnBecameInvisible = JSApi.getObjFunction(jsObjID, "OnBecameInvisible");
        idOnBecameVisible = JSApi.getObjFunction(jsObjID, "OnBecameVisible");
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

}