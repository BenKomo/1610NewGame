using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float Value = 50;

    void OnEnable()
    {
        
    }

    public void OnFloatData( float AddValue )
    {
        Value += AddValue;
    }
}
