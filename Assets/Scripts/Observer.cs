using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public void Observation()
    {
        Debug.Log(transform.name + " got control in Observation method");
    }
}
