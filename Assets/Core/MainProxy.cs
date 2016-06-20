using UnityEngine;

public class MainProxy : MonoBehaviour {

	void Awake () {
	    if (GameObject.Find("Main") == null)
	    {
            GameObject go = new GameObject("Main");
            DontDestroyOnLoad(go);
            go.AddComponent<Main>();
        }
    }
}
