using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityScript.Steps;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, TriggerEnterEvent, UpdateEvent, CollisionEnterEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        StartEvent.Invoke();
    }

    private void OnEnable()
    {
        EnableEvent.Invoke();
    }
 void Update()
    {
        UpdateEvent.Invoke();
    }
    private void OnMouseDown()
    {
        TriggerEnterEvent.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
        CollisionEnterEvent.Invoke();
        
    }
   
}
