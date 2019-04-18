using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{

    private Rigidbody rBody;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    public void ApplyForce(float force)
    {
        rBody.AddForce(0, force, 0);
    }

}
