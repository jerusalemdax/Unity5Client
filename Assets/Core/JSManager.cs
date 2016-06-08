using UnityEngine;

public class JSManager {

    private static JSManager _instance;

    public static JSManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new JSManager();
            }
            return _instance;
        }
    }

    public void Init()
    {
        GameObject go = new GameObject("JSManager");
        Object.DontDestroyOnLoad(go);
        JSEngine engine = go.AddComponent<JSEngine>();
        engine.guiX = 0;
        engine.debug = false;
        engine.GCInterval = 10000;
        engine.showStatistics = false;
        GameObject jsLoader = new GameObject("JSFileLoader");
        jsLoader.transform.parent = go.transform;
        engine.jsLoader = jsLoader.AddComponent<JSFileLoader>();
        engine.InitLoadScripts = new[] {"include"};
    }
}
