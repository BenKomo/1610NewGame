﻿using UnityEngine;
using UnityEngine.Events;

public class SpaceShipEvent : MonoBehaviour
{
    public UnityEvent Event;

    private void OnCollisionEnter2D()
    {
        Event.Invoke();
    }
}