using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityScript.Steps;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        StartEvent.Invoke();
    }

    private void OnEnable()
    {
        EnableEvent.Invoke();
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }

    

    // Update is called once per frame
    void Update()
    {
        UpdateEvent.Invoke();
    }
}
