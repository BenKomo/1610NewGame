using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
    public UnityEvent Event;
    public string Name;
    public FloatData Health;
    public FloatData Speed;
    public bool CanMove;

    protected Color newColor;


    public Color SkinColor;

    public void Move ()
    {
        print("Move");
    }
    
    // Start is called before the first frame update
    private void Start()
    { 
        Event.Invoke();
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Do Work
        
        
    }
}
