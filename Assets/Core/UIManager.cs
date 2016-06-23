using System.Collections;
using AssetBundles;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    private static UIManager _instance;

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

    public void Init()
    {
        Debug.Log("UIManager Start");
        GameObject go = new GameObject("UIManager");
        Object.DontDestroyOnLoad(go);
        Canvas canvas = go.AddComponent<Canvas>();
        Object.DontDestroyOnLoad(canvas);
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        CanvasScaler scaler = go.AddComponent<CanvasScaler>();
        Object.DontDestroyOnLoad(scaler);
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

    public void ClosePanel(string panelName)
    {
        Object.Destroy(GameObject.Find("UIManager/" + panelName));
    }

    IEnumerator LoadPrefabs(string panelName)
    {
        string assetBundleName = "UI/" + panelName + ".prefab.unity3d";
        var request = AssetBundleManager.LoadAssetAsync(assetBundleName.ToLower(), panelName, typeof(GameObject));
        if (request == null)
            yield break;
        yield return Main.StartCoroutineFunc(request);

        GameObject prefab = request.GetAsset<GameObject>();

        if (prefab != null)
        {
            var obj = Object.Instantiate(prefab) as GameObject;
            obj.name = prefab.name;
            obj.transform.SetParent(GameObject.Find("UIManager").transform, false);
        }

    }
}
