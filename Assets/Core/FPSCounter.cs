using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Text))]
public class FPSCounter : MonoBehaviour
{
    private const float FpsMeasurePeriod = 0.5f;
    private int _mFpsAccumulator = 0;
    private float _mFpsNextPeriod = 0;
    private int _mCurrentFps;
    private const string Display = "FPS: {0}";
    private Text _mText;


    private void Start()
    {
        _mFpsNextPeriod = Time.realtimeSinceStartup + FpsMeasurePeriod;
        _mText = GetComponent<Text>();
    }


    private void Update()
    {
        _mFpsAccumulator++;
        if (Time.realtimeSinceStartup > _mFpsNextPeriod)
        {
            _mCurrentFps = (int) (_mFpsAccumulator/FpsMeasurePeriod);
            _mFpsAccumulator = 0;
            _mFpsNextPeriod += FpsMeasurePeriod;
            _mText.text = string.Format(Display, _mCurrentFps);
        }
    }
}