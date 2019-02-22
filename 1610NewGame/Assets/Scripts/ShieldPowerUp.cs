using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScript.Steps;

[CreateAssetMenu]
public class ShieldPowerUp : ScriptableObject

{
    public float Value = 50;
    
    void OnEnable()

    {
        Value = 10;
    }

    public void OnShieldPowerUp(float AddValue)
    {
        Value += AddValue;
    }



}
