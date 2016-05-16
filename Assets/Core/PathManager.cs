using UnityEngine;

public class PathManager
{
#if UNITY_EDITOR
    private static string _readWritePath = Application.dataPath + "/../PersistentData/";
    private static string _readOnlyPath = Application.dataPath + "/../StreamingAssets/";
    private static string _readWritePathWithPrefix = "file:///" + Application.dataPath + "/../PersistentData/";
    private static string _readOnlyPathWithPrefix = "file:///" + Application.dataPath + "/../StreamingAssets/";
#elif UNITY_STANDALONE
    private static string _readWritePath = Application.dataPath + "/PersistentData/";
    private static string _readOnlyPath = Application.streamingAssetsPath + "/";
    private static string _readWritePathWithPrefix = "file:///" + Application.dataPath + "/PersistentData/";
    private static string _readOnlyPathWithPrefix = "file:///" + Application.streamingAssetsPath + "/";
#elif UNITY_ANDROID
    private static string _readWritePath = Application.persistentDataPath + "/";
    private static string _readOnlyPath = Application.streamingAssetsPath + "/";
    private static string _readWritePathWithPrefix = Application.persistentDataPath + "/";
    private static string _readOnlyPathWithPrefix = Application.streamingAssetsPath + "/";
#else
    private static string _readWritePath = Application.persistentDataPath + "/";
    private static string _readOnlyPath = Application.streamingAssetsPath + "/";
    private static string _readWritePathWithPrefix = "file:///" + Application.persistentDataPath + "/";
    private static string _readOnlyPathWithPrefix = "file:///" + Application.streamingAssetsPath + "/";
#endif

    public static string GetReadWritePath(string path)
    {
        return _readWritePath + path;
    }

    public static string GetReadOnlyPath(string path)
    {
        return _readOnlyPath + path;
    }

    public static string GetReadWritePathWithPrefix(string path)
    {
        return _readWritePathWithPrefix + path;
    }

    public static string GetReadOnlyPathWithPrefix(string path)
    {
        return _readOnlyPathWithPrefix + path;
    }
}
