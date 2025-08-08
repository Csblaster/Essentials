using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Variables/SimpleIntData")]
public class SimpleIntData : ScriptableObject
{
    public int value;
    public UnityEvent OnValueChanged = new UnityEvent();

    [Header("Threshold Settings")]
    public int threshold = 100;
    public UnityEvent OnThresholdReached = new UnityEvent();
    private bool thresholdTriggered = false; // optional: to only trigger once

    public void AddValue(int amount)
    {
        value += amount;
        OnValueChanged.Invoke();
        CheckThreshold();
    }

    public void SetValue(int amount)
    {
        value = amount;
        OnValueChanged.Invoke();
        CheckThreshold();
    }

    private void CheckThreshold()
    {
        if (!thresholdTriggered && value >= threshold)
        {
            OnThresholdReached.Invoke();
            thresholdTriggered = true; // remove this if you want it to fire repeatedly
        }
    }
}
