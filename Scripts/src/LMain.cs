using System.Text;
using UnityEngine;

public class LMain
{
	public void Start()
	{
	    Debug.Log("LMain Start");
	    ResourceManager.Instance.LoadResourceBytes("Config/Engine.json", bytes =>
	    {
	        Config.EngineConfig = JsonUtility.FromJson<EngineConfig>(Encoding.UTF8.GetString(bytes));
	        Debug.Log("Use Assetbundle: " + Config.EngineConfig.UseAssetbundle);
	        UIManager.Instance.Start();
	        UpdateManager.Instance.Start();
        });
    }

	public void OnDestroy()
	{
        UIManager.Instance.OnDestroy();
        UpdateManager.Instance.OnDestroy();
        Debug.Log("LMain OnDestroy");
    }
}