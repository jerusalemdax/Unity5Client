using System.IO;
using UnityEditor;
using UnityEngine;
using AssetBundles;

public class AssetBuildTool{

    public static void BuildAssetBundles(BuildTarget target)
    {
        // Choose the output path according to the build target.
        string outputPath = Path.Combine(Utility.AssetBundlesOutputPath, Utility.GetPlatformForAssetBundles(target));
        if (!Directory.Exists(outputPath))
            Directory.CreateDirectory(outputPath);

        //@TODO: use append hash... (Make sure pipeline works correctly with it.)
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, target);
    }
}
