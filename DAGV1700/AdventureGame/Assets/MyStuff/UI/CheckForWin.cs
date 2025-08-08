using UnityEngine;
using UnityEngine.Events;

public class CheckForWin : MonoBehaviour
{
    [Header("Collectible Settings")]
    public int currentCount = 0;
    public int threshold = 10;

    [Header("Events")]
    public UnityEvent OnThresholdReached;

    private bool thresholdReached = false;

    /// <summary>
    /// Call this method whenever an item is collected.
    /// </summary>
    /// <param name="amount">How many items collected (default 1)</param>
    public void AddCollectibles(int amount = 1)
    {
        if (thresholdReached) return; // prevent multiple triggers

        currentCount += amount;
        Debug.Log($"Collected {amount} item(s). Current count: {currentCount}");

        if (currentCount >= threshold)
        {
            thresholdReached = true;
            Debug.Log("Threshold reached!");
            OnThresholdReached?.Invoke();
        }
    }
}