using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    public UnityEvent OnGrounded, OffGrounded;

    public float Speed = 3;
    public float Gravity = -1;
    public float JumpForce = 30;
    

    private CharacterController controller;

    private Vector3 position;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            OffGrounded.Invoke();
        }

        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            position.y = JumpForce;
        }
        
        position.y += Gravity * Time.deltaTime;
        

       // if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
       // {
       //      position.y = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        //}
       // else
        //{
        //     position.y = Gravity * Time.deltaTime;
       // } 

        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        
        controller.Move(position);
        
    }
    
   
}
