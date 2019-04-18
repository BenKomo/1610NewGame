using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParam : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
       AddDate(12.5f, 8.5f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private static void AddDate(float a, float b)
    {
        print(a+b);
    }

    private void OnTriggerExit(Collider obj)
    {
        obj.gameObject.SetActive(false);
    }
}
