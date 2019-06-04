using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using System;

public class ControlVR : MonoBehaviour {

    // Update is called once per frame
    void Update () {
        
        
        if (OVRInput.GetDown(OVRInput.Button.One))
        {

            Debug.Log(OVRInput.Button.One);
        }

    }

    public void test()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {

            Debug.Log("Wuuuuu");
        }

    }
}
