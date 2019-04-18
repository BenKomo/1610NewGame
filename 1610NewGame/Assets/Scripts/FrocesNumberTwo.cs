using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools.Utils;

public class FrocesNumberTwo : MonoBehaviour
{

    public Vector3 ForceAmount;

    private Rigidbody rBody;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    public void ApplyForce()
    {
        rBody.AddForce(ForceAmount);
    }
}
