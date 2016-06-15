using System.IO;
using UnityEngine;

public class PathManager
{
#if UNITY_EDITOR
    private static string _readWritePath = Application.dataPath + "/../PersistentData/";
    private static string _readOnlyPath = Application.dataPath + "/../StreamingAssets/";
#elif UNITY_STANDALONE
    private static string _readWritePath = Application.dataPath + "/PersistentData/";
    private static string _readOnlyPath = Application.streamingAssetsPath + "/";
#elif UNITY_ANDROID
    private static string _readWritePath = Application.persistentDataPath + "/";
    private static string _readOnlyPath = Application.streamingAssetsPath + "/";
#else
    private static string _readWritePath = Application.persistentDataPath + "/";
    private static string _readOnlyPath = Application.streamingAssetsPath + "/";
#endif

    public static string GetReadWritePath(string path)
    {
        return _readWritePath + path;
    }

    public static string GetReadOnlyPath(string path)
    {
        return _readOnlyPath + path;
    }

    public static string AddFilePrefix(string str)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        return str;
#else
        return "file:///" + str;
#endif
    }

    public static string GetConfigPath()
    {
#if UNITY_EDITOR
        return Path.Combine(Application.dataPath + "/../", "Config");
#else
        return GetReadOnlyPath("Config");
#endif
    }
}
