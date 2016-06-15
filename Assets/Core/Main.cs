using System.Collections;
using System.Text;
using AssetBundles;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    private static Main Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Debug.Log("Unity version: " + Application.unityVersion);
        Debug.Log("Platform: " + Application.platform);

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

            var task = InitAsync();
            if (task != null)
            {
                Main.StartCoroutineFunc(InitAsync());
            }
        });
    }

    static IEnumerator InitAsync()
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
    }

    void Update()
    {
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