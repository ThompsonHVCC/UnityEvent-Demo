using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Crayon : MonoBehaviour
{
    // The following estalbishes an Event, which I call crayonEvent
    public  UnityEvent crayonEvent;


    void Update()
    {
        // Check to see if the user has clicked on us, and if so invoke the event handler(s) 
        // You can think of this as "publishing" the event
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Detected left mouse button on " + transform.name);
            crayonEvent.Invoke();
        }
    }
}
