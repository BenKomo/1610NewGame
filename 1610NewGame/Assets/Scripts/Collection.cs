using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{

    public List<FloatData> CollectionList;
    
    public void Collect(FloatData obj)
    {
        CollectionList.Add(obj);
    }

    public void CollectionInfo()
    {
        foreach (var obj in CollectionList)
        {
            Debug.Log(obj);
        }
        
    }

    public void AmmoInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "Ammo")
            {
                Debug.Log("We have " + obj.Value + "  Ammo.");
            }
        } 
    }
}
