using UnityEditor;
using UnityEngine;

public class CustomAssetPostprocessor : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (var str in importedAssets)
        {
            if (str.EndsWith(".cs") || str.StartsWith("ProjectSettings/") || str.Equals("Assets") || str.Equals("Assets/Scenes/Start.unity"))
            {
                return;
            }
            Debug.Log("Imported Asset: " + str);
            AssetImporter assetImporter = AssetImporter.GetAtPath(str);
            assetImporter.assetBundleName = str.Replace("Assets/", "");
        }
    }
}
