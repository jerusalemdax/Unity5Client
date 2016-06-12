using UnityEngine;

public class MainProxy : MonoBehaviour {

	void Awake () {
        GameObject go = new GameObject("Main");
        DontDestroyOnLoad(go);
        go.AddComponent<Main>();
    }
}
