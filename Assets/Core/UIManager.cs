using System.Collections;
using AssetBundles;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static void Init()
    {
        Debug.Log("UIManager Start");
        GameObject go = new GameObject("UIManager");
        DontDestroyOnLoad(go);
        Canvas canvas = go.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        CanvasScaler scaler = go.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(960, 640);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 1.0f;
    }

    public static void ShowPanel(string panelName)
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
            obj.transform.SetParent(GameObject.Find("UIManager").transform, false);
        }

    }
}
