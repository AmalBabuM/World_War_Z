using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLook : MonoBehaviour
{
    public GameObject scope;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            scope.SetActive(true);
        }
        else
        {
            scope.SetActive(false);
        }
    }
}
