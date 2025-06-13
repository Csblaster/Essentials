using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    [Tooltip("How much to multiply the player's speed by.")]
    public float speedMultiplier = 2f;

    [Tooltip("How long the speed boost lasts in seconds.")]
    public float duration = 5f;

    [Tooltip("Should the item destroy itself after being picked up?")]
    public bool destroyOnPickup = true;

    }