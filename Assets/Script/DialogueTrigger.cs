using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    void OnTriggerEnter (Collider Cube)
    {
        Debug.Log ("Object Entered the trigger");
    }

    void OnTriggerStay (Collider Cube)
    {
        Debug.Log ("Object is within the trigger");
    }

    void OnTriggerExit (Collider Cube)
    {
        Debug.Log ("Object Exited the trigger");
    }

}
