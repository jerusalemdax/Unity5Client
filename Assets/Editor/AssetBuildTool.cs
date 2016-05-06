using System.IO;
using UnityEditor;
using UnityEngine;

public class AssetBuildTool{

    [MenuItem("Build/Resources")]
	public static void BuildBundle ()
    {
        string path = PathManager.GetReadOnlyPath("");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.DeterministicAssetBundle, BuildTarget.StandaloneWindows);
    }
}
