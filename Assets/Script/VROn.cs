using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VROn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XRSettings.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void SwitchToVR()
    {
        XRSettings.enabled = true;
    }
}
