using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Text))]
public class FPSCounter : MonoBehaviour
{
    private const float FpsMeasurePeriod = 0.5f;
    private int _mFpsAccumulator;
    private float _mFpsNextPeriod;
    private int _mCurrentFps;
    private Text _mFPSText;
    private const string _fpsDisplay = "FPS: {0}";

    private void Start()
    {
        _mFpsNextPeriod = Time.realtimeSinceStartup + FpsMeasurePeriod;
        _mFPSText = GetComponent<Text>();
    }


    private void Update()
    {
        _mFpsAccumulator++;
        if (Time.realtimeSinceStartup > _mFpsNextPeriod)
        {
            _mCurrentFps = (int) (_mFpsAccumulator/FpsMeasurePeriod);
            _mFpsAccumulator = 0;
            _mFpsNextPeriod += FpsMeasurePeriod;
            _mFPSText.text = string.Format(_fpsDisplay, _mCurrentFps);
        }
    }
}