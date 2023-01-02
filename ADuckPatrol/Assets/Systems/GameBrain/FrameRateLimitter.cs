using UnityEngine;

public class FrameRateLimitter : MonoBehaviour
{
    [SerializeField, Range(20, 120)] private int targetFrameRate = 30;

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = targetFrameRate;
    }
}