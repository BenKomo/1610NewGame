using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
    protected Vector3 position;
        public float Speed = 25;
        public float JumpForce = 2;
        public float Gravity = -3;
    public abstract void Move(CharacterController controller);
}
 