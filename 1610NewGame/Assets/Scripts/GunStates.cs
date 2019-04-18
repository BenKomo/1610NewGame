using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class GunStates : MonoBehaviour
{

    public UnityEvent ShootingEvent, ReloadingEvent, PowershotEvent;

    public enum States
    {
        Shooting, 
        Reloading,
        Powershot
    }

    public States CurrentStates;


    private void OnSwitch()
    {
        switch (CurrentStates)
        {
            case States.Shooting:
                ShootingEvent.Invoke();
                break;
            case States.Reloading:
                ReloadingEvent.Invoke();
                break;
            case States.Powershot:
                PowershotEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
