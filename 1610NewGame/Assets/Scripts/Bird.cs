using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bird : Animal

{
    public int FeatherCount = 1000;
    public float EatSpeed = 0.5f;
    public bool CanEat = true;
    public UnityEvent Event;

    public Color FeatherColor; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
