using UnityEngine;
public class CSharpGenerated
{
    public static void RegisterAll()
    {
        if (JSMgr.allCallbackInfo.Count != 0)
        {
            Debug.LogError(999777454);
        }
        SceneManagerExGenerated.__Register();
        UIManagerGenerated.__Register();
        UnityEngine_MonoBehaviourGenerated.__Register();
        UnityEngine_BehaviourGenerated.__Register();
        UnityEngine_ComponentGenerated.__Register();
        UnityEngine_ObjectGenerated.__Register();
        UnityEngine_DebugGenerated.__Register();

    }
}
