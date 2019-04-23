using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class RunAnims : MonoBehaviour
{
    private Animator anims;
    public float Speed;
    
    // Start is called before the first frame update
    void Start()
    {
        anims = GetComponent<Animator>();
    }

    void Update()
    {
       anims.SetFloat("Speed", Speed);
    }

   
}
