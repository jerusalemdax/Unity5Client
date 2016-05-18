using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class MemoryCounter : MonoBehaviour {

    private float _mLastTime;
    private Text _mMemText;
    private const string _memDisplay = "Memory: {0}M";
    void Start () {
        _mMemText = GetComponent<Text>();
    }

	void Update () {
        if (Time.realtimeSinceStartup - _mLastTime > 0.5)
        {
            _mMemText.text = string.Format(_memDisplay, Profiler.GetTotalAllocatedMemory() >> 20);
            _mLastTime = Time.realtimeSinceStartup;
        }
	}
}
