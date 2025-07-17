using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Single Variables/SimpleIntData")]
public class SimpleIntData : ScriptableObject
{
    public int value;
    public UnityEvent OnValueChanged = new UnityEvent();

    public void AddValue(int amount)
    {
        value += amount;
        OnValueChanged.Invoke();
    }

    public void SetValue(int amount)
    {
        value = amount;
        OnValueChanged.Invoke();
    }
}