using UnityEditor;
using UnityEngine;

public class CustomAssetPostprocessor : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (var str in importedAssets)
        {
            if (str.EndsWith(".prefab") || str.EndsWith(".jpg") || str.StartsWith(".png") || (str.EndsWith(".unity") && !str.Equals("Start.unity")))
            {
                Debug.Log("Imported Asset: " + str);
                AssetImporter assetImporter = AssetImporter.GetAtPath(str);
                assetImporter.assetBundleName = str.Replace("Assets/", "");
            }

        }
    }
}
