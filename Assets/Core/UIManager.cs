using System.Collections;
using AssetBundles;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    private static UIManager _instance;
    private UIManager() { }
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UIManager();
            }
            return _instance;
        }
    }

    public void Start()
    {
        Debug.Log("UIManager Start");
        GameObject go = new GameObject("UI");
        Canvas canvas = go.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        CanvasScaler scaler = go.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(960, 640);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 1.0f;
    }

    public void ShowPanel(string panelName)
    {
        Debug.Log("ShowPanel: " + panelName);

        Main.StartCoroutineFunc(LoadPrefabs(panelName));

    }

    static IEnumerator LoadPrefabs(string panelName)
    {
        string assetBundleName = "Prefabs/" + panelName + ".prefab";
        var request = AssetBundleManager.LoadAssetAsync(assetBundleName.ToLower(), panelName, typeof(GameObject));
        if (request == null)
            yield break;
        yield return Main.StartCoroutineFunc(request);

        GameObject prefab = request.GetAsset<GameObject>();

        if (prefab != null)
        {
            var obj = Object.Instantiate(prefab) as GameObject;
            obj.name = prefab.name;
            obj.transform.SetParent(GameObject.Find("UI").transform, false);
        }

    }

    public void OnDestroy()
    {
        Debug.Log("UIManager OnDestroy");
    }
}
