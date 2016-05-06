using UnityEngine;
using System;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif
using Object = UnityEngine.Object;

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

    public void LoadResourceObj(string path, Action<Object[]> callback)
    {
#if !UNITY_EDITOR
        callback(AssetDatabase.LoadAssetAtPath("Assets/" + path, typeof(GameObject)));
#else
        Main.StartCoroutineFunc(LoadResourceObjCor(path, callback));
#endif
    }

    public void LoadResourceBytes(string path, Action<byte[]> callback)
    {
        Main.StartCoroutineFunc(LoadResourceBytesCor(path, callback));
    }

    private IEnumerator LoadResourceObjCor(string path, Action<Object[]> callback)
    {
        string fullPath = PathManager.GetReadOnlyPathWithPrefix(path);
        WWW www = new WWW(fullPath);
        yield return www;
        if (www.isDone)
        {
            if (string.IsNullOrEmpty(www.error))
            {
                callback(www.assetBundle.LoadAllAssets());
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

    private IEnumerator LoadResourceBytesCor(string path, Action<byte[]> callback)
    {
        string fullPath = PathManager.GetReadOnlyPathWithPrefix(path);
        WWW www = new WWW(fullPath);
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
