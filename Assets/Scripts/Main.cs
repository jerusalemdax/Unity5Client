using SLua;
using UnityEngine;

public class Main : MonoBehaviour
{
    private LuaSvr lua;
    void Start()
    {
        Debug.Log("Unity version: " + Application.unityVersion);

        lua = new LuaSvr();
        lua.init(Tick, Complete);
    }

    void Update()
    {

    }

    void Tick(int p)
    {
    }

    void Complete()
    {
        lua.start("main");
    }
}
