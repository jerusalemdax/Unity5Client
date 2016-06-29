using System.Collections;
using AssetBundles;
using UnityEngine;

public class Main : MonoBehaviour
{
    private static Main Instance;
    private bool bInitFinish;

    void Awake()
    {
        Instance = this;
        Debug.Log("Unity version: " + Application.unityVersion);
        Debug.Log("Platform: " + Application.platform);
        Debug.Log("Application name: " + Application.productName);
        Debug.Log("Company name: " + Application.companyName);
        Debug.Log("Application bundle identifier: " + Application.bundleIdentifier);
        Debug.Log("Application version: " + Application.version);

        ResourceManager.Instance.LoadConfig("Engine.json", str =>
        {
            ConfigManager.EngineConfig = JsonUtility.FromJson<EngineConfig>(str);
            if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
            {
                if (ConfigManager.EngineConfig.OpenBugly)
                {
                    Debug.Log("Bugly version: " + BuglyAgent.PluginVersion);
                    if (Debug.isDebugBuild)
                    {
                        BuglyAgent.ConfigDebugMode(true);
                    }
                    else
                    {
                        BuglyAgent.ConfigDebugMode(false);
                    }
                    if (Application.platform == RuntimePlatform.Android)
                    {
                        BuglyAgent.InitWithAppId("900026712");
                    }
                    else if (Application.platform == RuntimePlatform.IPhonePlayer)
                    {
                        BuglyAgent.InitWithAppId("900026732");
                    }
                    BuglyAgent.EnableExceptionHandler();
                }
            }
        });
    }

    IEnumerator Start()
    {
        AssetBundleManager.SetSourceAssetBundleURL(PathManager.AddFilePrefix(PathManager.GetReadOnlyPath("")));
        var request = AssetBundleManager.Initialize();
        if (request == null)
        {
            yield return null;
        }
        else
        {
            yield return Main.StartCoroutineFunc(request);
        }
        UIManager.Instance.Init();
        if (ConfigManager.EngineConfig.ShowStat)
        {
            UIManager.Instance.ShowPanel("StatPanel");
        }
        SceneManagerEx.Instance.Init();
        JSManager.Instance.Init();
        ProtocalManager.Instance.Init();
        bInitFinish = true;
    }

    void Update()
    {
        if (bInitFinish)
        {
            ProtocalManager.Instance.Update();
        }
    }

    void OnDestroy()
    {
        Debug.Log("Main OnDestroy");
    }

    public static Coroutine StartCoroutineFunc(IEnumerator func)
    {
        return Instance.StartCoroutine(func);
    }
}