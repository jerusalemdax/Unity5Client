using System.Collections;
using System.Text;
using AssetBundles;
using UnityEngine;

public class LMain
{
	public void Start()
	{
	    Debug.Log("LMain Start");
        ResourceManager.Instance.LoadResourceBytes("Config/Engine.json", bytes =>
	    {
            Config.EngineConfig = JsonUtility.FromJson<EngineConfig>(Encoding.UTF8.GetString(bytes));
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
        UpdateManager.Instance.Start();
    }

    public void OnDestroy()
	{
        UpdateManager.Instance.OnDestroy();
        Debug.Log("LMain OnDestroy");
    }
}