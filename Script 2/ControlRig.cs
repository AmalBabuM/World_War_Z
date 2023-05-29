using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class ControlRig : MonoBehaviour
{
   
    RigBuilder rb;
    // Start is called before the first frame update
    void Start()
    {   

        rb= GetComponent<RigBuilder>();
    }

    // Update is called once per frame
    void Update()
    {
        bool walk = Input.GetKey("w");
        bool walkBack = Input.GetKey("s");
        bool walkRight = Input.GetKey("d");
        bool walkLeft = Input.GetKey("a");
        if (Input.GetButton("Fire2")&& !walk &&!walkBack && !walkRight && !walkLeft) 
        {
            rb.enabled = true;   
        }
        else
        {
            rb.enabled = false;
        }
    }
}
