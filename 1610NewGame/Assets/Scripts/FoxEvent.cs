﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FoxEvent : MonoBehaviour
{
    public UnityEvent Event;

    private void OnCollisionEnter2D()
    {
        Event.Invoke();
      
    }
}
