using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour
{
   public bool CanWalk;
   public int Number = 11;
   public string Password;

   private void Update()
   {
      if (CanWalk)
      {
         print("True");
      }
      else
      {
         print("False");
      }

      if (Number >= 10)
      {
         print("Greater");
      }
      else
      {
         print("Lesser");
      }
      
      if (Password ==  "OU812")
      {
         print("The password is correct");
      }
      else
      {
         print("The password is incorrect");
      }
   }
}
