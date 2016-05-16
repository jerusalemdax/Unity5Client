using System.Collections;
using System.IO;
using System.Text;
using AssetBundles;
using UnityEngine;

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

        ResourceManager.Instance.LoadResourceBytes("Config/Engine.json", bytes =>
        {
            ConfigManager.EngineConfig = JsonUtility.FromJson<EngineConfig>(Encoding.UTF8.GetString(bytes));
            Debug.Log("ping test: " + ConfigManager.EngineConfig.ShowStat);
            var task = InitAsync();
            if (task != null)
            {
                Main.StartCoroutineFunc(InitAsync());
            }
        });
    }

    static IEnumerator InitAsync()
    {
        AssetBundleManager.SetSourceAssetBundleURL(PathManager.GetReadOnlyPathWithPrefix("/"));
        var request = AssetBundleManager.Initialize();
        if (request == null)
        {
            yield return null;
        }
        else
        {
            yield return Main.StartCoroutineFunc(request);
        }
        UIManager.Init();
        if (ConfigManager.EngineConfig.ShowStat)
        {
            UIManager.ShowPanel("StatPanel");
        }
        UpdateManager.Instance.Start();
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