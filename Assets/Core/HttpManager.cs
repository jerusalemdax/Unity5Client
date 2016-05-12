using System;
using System.Collections;
using UnityEngine;

public class HttpManager{

    private static HttpManager _instance;

    public static HttpManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new HttpManager();
            }
            return _instance;
        }
    }

    public void StartHttpGet(string url, Action<string> callback)
    {
        Main.StartCoroutineFunc(StartHttpGetCor(url, callback));
    }

    private IEnumerator StartHttpGetCor(string url, Action<string> callback)
    {
        Debug.Log("HttpManager request: " + url);
        WWW www = new WWW(url);
        yield return www;
        if (www.isDone)
        {
            if (string.IsNullOrEmpty(www.error))
            {
                callback(www.text);
            }
            else
            {
                Debug.LogError("HttpManager www error: " + www.error);
            }
        }
        else
        {
            Debug.LogError("HttpManager www is not done");
        }
    }
}
