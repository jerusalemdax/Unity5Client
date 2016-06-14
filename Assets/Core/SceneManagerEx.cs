using AssetBundles;
using System.Collections;
using UnityEngine;

/// <summary>
/// 场景管理器，管理场景的加载和变更。因为UnityEngine已经有一个类叫SceneManager，所以这个自定义的场景管理器叫SceneManagerEx
/// </summary>
public class SceneManagerEx {

    private static SceneManagerEx _instance;

    public static SceneManagerEx Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SceneManagerEx();
            }
            return _instance;
        }
    }

    public void Init()
    {
        Debug.Log("SceneManager Init");
        GameObject go = new GameObject("SceneManager");
        Object.DontDestroyOnLoad(go);
    }

    public void ShowScene(string scene)
    {
        Debug.Log("Show Scene: " + scene);

        Main.StartCoroutineFunc(LoadScene(scene));
    }

    private IEnumerator LoadScene(string scene)
    {
        string assetBundleName = "Scenes/" + scene + ".unity.unity3d";
        var request = AssetBundleManager.LoadLevelAsync(assetBundleName.ToLower(), scene, false); ;
        if (request == null)
            yield break;
        yield return Main.StartCoroutineFunc(request);
    }
}
