using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{

   public float Value = 10;
   
   void OnEnable()
   { 
      
   }

   public void OnPowerUp(float AddValue)
   {
      Value += AddValue; 
   }
   
}
