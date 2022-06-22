using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "ScriptableObjects/IntVariable", order = 2)]
public class IntVariable : ScriptableObject
{
    #if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
    #endif

    private int _value = 0;
    public int Value
    {
        get
        {
            return _value;
        }
    }

    public void SetValue(int value)
    {
        _value = value;
    }

    // Overload
    public void SetValue(IntVariable value)
    {
        _value = value._value;
    }

    public void ApplyChange(int amount)
    {
        _value += amount;
    }

    // Overload
    public void ApplyChange(IntVariable amount)
    {
        _value += amount._value;
    }
}
