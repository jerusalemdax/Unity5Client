using System.Collections.Generic;
using System.IO;
using AssetBundles;
using UnityEditor;
using UnityEngine;

public class UnityBuildTool{

    [MenuItem("Build/Windows/Debug")]
    public static void BuildWindowsDebug()
    {
        BuildPlayer(BuildTarget.StandaloneWindows, true);
    }

    [MenuItem("Build/Windows/Release")]
    public static void BuildWindowsRelease()
    {
        BuildPlayer(BuildTarget.StandaloneWindows, false);
    }

    [MenuItem("Build/Android/Debug")]
    public static void BuildAndroidDebug()
    {
        BuildPlayer(BuildTarget.Android, true);
    }

    [MenuItem("Build/Android/Release")]
    public static void BuildAndroidRelease()
    {
        BuildPlayer(BuildTarget.Android, false);
    }

    [MenuItem("Build/iOS/Debug")]
    public static void BuildIOSDebug()
    {
        BuildPlayer(BuildTarget.iOS, true);
    }

    [MenuItem("Build/iOS/Release")]
    public static void BuildIOSRelease()
    {
        BuildPlayer(BuildTarget.iOS, false);
    }

    public static void BuildPlayer(BuildTarget target, bool isDebug)
    {
        var outputPath = Application.dataPath + "/../Build/";

        string[] levels = GetLevelsFromBuildSettings();
        if (levels.Length == 0)
        {
            Debug.Log("Nothing to build.");
            return;
        }

        string targetName = GetBuildTargetName(target);
        if (targetName == null)
            return;

        AssetBuildTool.BuildAssetBundles(target);

        BuildOptions option = isDebug ? BuildOptions.Development : BuildOptions.None;
        string modeString = isDebug ? "/Debug" : "/Release";
        CopyAssetBundlesTo(target, Application.streamingAssetsPath);
        FileUtil.CopyFileOrDirectory(Path.GetFullPath(Application.dataPath + "/../JavaScript"), Application.streamingAssetsPath + "/JavaScript");
        FileUtil.CopyFileOrDirectory(Path.GetFullPath(Application.dataPath + "/../Config"), Application.streamingAssetsPath + "/Config");

        outputPath = outputPath + Utility.GetPlatformForAssetBundles(target) + modeString;
        if (Directory.Exists(outputPath))
        {
            Directory.Delete(outputPath, true);
        }
        Directory.CreateDirectory(outputPath);
        outputPath = outputPath + targetName;
        BuildPipeline.BuildPlayer(levels, outputPath, target, option);

        FileUtil.DeleteFileOrDirectory(Application.streamingAssetsPath);
        FileUtil.DeleteFileOrDirectory(Application.streamingAssetsPath + ".meta");
    }

    static string[] GetLevelsFromBuildSettings()
    {
        List<string> levels = new List<string>();
        for (int i = 0; i < EditorBuildSettings.scenes.Length; ++i)
        {
            if (EditorBuildSettings.scenes[i].enabled)
                levels.Add(EditorBuildSettings.scenes[i].path);
        }

        return levels.ToArray();
    }

    public static string GetBuildTargetName(BuildTarget target)
    {
        switch (target)
        {
            case BuildTarget.Android:
                return "/Client.apk";
            case BuildTarget.StandaloneWindows:
            case BuildTarget.StandaloneWindows64:
                return "/Client.exe";
            case BuildTarget.StandaloneOSXIntel:
            case BuildTarget.StandaloneOSXIntel64:
            case BuildTarget.StandaloneOSXUniversal:
                return "/Client.app";
            case BuildTarget.WebPlayer:
            case BuildTarget.WebPlayerStreamed:
            case BuildTarget.WebGL:
            case BuildTarget.iOS:
                return "";
            // Add more build targets for your own.
            default:
                Debug.Log("Target not implemented.");
                return null;
        }
    }

    static void CopyAssetBundlesTo(BuildTarget target, string outputPath)
    {
        FileUtil.DeleteFileOrDirectory(Application.streamingAssetsPath);
        Directory.CreateDirectory(outputPath);

        List<string> copyDirs = new List<string>();
        copyDirs.Add(Utility.GetPlatformForAssetBundles(target));

        foreach (var dir in copyDirs)
        {
            var source = Path.Combine(Path.Combine(System.Environment.CurrentDirectory, Utility.AssetBundlesOutputPath), dir);
            if (!Directory.Exists(source))
                Debug.Log("No assetBundle output folder, try to build the assetBundles first.");

            var destination = Path.Combine(outputPath, dir);
            if (Directory.Exists(destination))
                FileUtil.DeleteFileOrDirectory(destination);

            FileUtil.CopyFileOrDirectory(source, destination);
        }
    }
}
