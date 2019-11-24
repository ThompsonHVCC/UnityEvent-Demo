using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Observer : MonoBehaviour
{

    UnityEvent cacheEvent;

    public void Observation()
    {
        Debug.Log(transform.name + " got control in Observation method");
    }

    // Note: Best practice? is to add a dynamic listener when the GO is enabled, and to 
    // also have logic to remove the listener when the GO is disabled 

    public void OnEnable()
    {
        Debug.Log(transform.name + " got control in OnEnable");

        cacheEvent = GameObject.Find("Crayon").GetComponent<Crayon>().crayonEvent;

        // Add ourself as a listener 
       cacheEvent.AddListener(Observation);

    }

    public void OnDisable()
    {
        Debug.Log(transform.name + " got control in OnDisable");
        // Remove listener
        cacheEvent.RemoveListener(Observation);
    }
}
