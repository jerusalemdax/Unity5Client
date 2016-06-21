using UnityEngine;
using System;
using System.Collections;
using System.IO;
using System.Text;

public class ResourceManager
{

    private static ResourceManager _instance;

    public static ResourceManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ResourceManager();
            }
            return _instance;
        }
    }

    public void LoadConfig(string path, Action<string> callback)
    {
        string configPath = PathManager.AddFilePrefix(Path.Combine(PathManager.GetConfigPath(), path));
        Main.StartCoroutineFunc(LoadResourceBytesCor(configPath, bytes =>
        {
            callback(Encoding.UTF8.GetString(bytes));
        }));
    }

    private IEnumerator LoadResourceBytesCor(string path, Action<byte[]> callback)
    {
        WWW www = new WWW(path);
        yield return www;
        if (www.isDone)
        {
            if (string.IsNullOrEmpty(www.error))
            {
                callback(www.bytes);
            }
            else
            {
                Debug.LogError("Load resource error: " + www.error);
            }
        }
        else
        {
            Debug.LogError("Load resource error: is done is false");
        }
    }
}
