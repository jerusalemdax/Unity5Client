using UnityEditor;
using UnityEngine;

public class CustomAssetPostprocessor : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (var str in importedAssets)
        {
            if (str.StartsWith("Assets/StreamingAssets"))
            {
                continue;
            }
            if (str.EndsWith(".prefab") || str.EndsWith(".jpg") || str.StartsWith(".png") || (str.EndsWith(".unity") && !str.Contains("Start.unity")))
            {
                Debug.Log("Imported Asset: " + str);
                AssetImporter assetImporter = AssetImporter.GetAtPath(str);
                assetImporter.assetBundleName = str.Replace("Assets/", "") + ".unity3d";
            }

        }
    }
}
