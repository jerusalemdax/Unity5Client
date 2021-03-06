﻿using System;
using System.Collections.Generic;
using UnityEngine;
using Pomelo.DotNetClient;
using SimpleJson;

public class ProtocalManager{

    private static ProtocalManager _instance;

    private PomeloClient _pclient;
    private Queue<KeyValuePair<Action<string>, string>> _callbacks = new Queue<KeyValuePair<Action<string>, string>>();
    private NetWorkState _networkState;

    public static ProtocalManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ProtocalManager();
            }
            return _instance;
        }
    }

    public void Init()
    {
        Debug.Log("ProtocalManager Init");
        string host = "127.0.0.1";
        int port = 3010;
        _pclient = new PomeloClient();

        _pclient.NetWorkStateChangedEvent += (state) =>
        {
            Debug.Log("Network state changed: " + state);
            _networkState = state;
            //TODO 网络状态变化的时候做一些操作
        };

        _pclient.initClient(host, port, () =>
        {
            JsonObject user = new JsonObject();
            _pclient.connect(user, data =>
            {
                Debug.Log("Connect server: " + data);
            });
        });
    }

    public void Update()
    {
        if (_callbacks.Count > 0)
        {
            var callback = _callbacks.Dequeue();
            callback.Key.Invoke(callback.Value);
        }
    }

    public void Request(string route, JsonObject msg, Action<string> action)
    {
        if (_networkState == NetWorkState.CONNECTED)
        {
            msg = new JsonObject();
            _pclient.request(route, msg, (data) =>
            {
                Debug.Log(string.Format("route {0} receive message: {1}", route, data));
                _callbacks.Enqueue(new KeyValuePair<Action<string>, string>(action, data.ToString()));
            });
        }
        else
        {
            var data = new JsonObject {{"code", 600}};
            _callbacks.Enqueue(new KeyValuePair<Action<string>, string>(action, data.ToString()));
        }
    }
}
