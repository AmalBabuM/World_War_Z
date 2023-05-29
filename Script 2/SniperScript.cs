using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScript : MonoBehaviour
{
    public GameObject scopeMode;
    public GameObject sniperScopeView;
    public GameObject secondPersonView;
    public GameObject redDot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetButton("Fire2"))
        {
            redDot.SetActive(false);
            scopeMode.SetActive(true);
        }
        else
        {
            redDot.SetActive(true);
            scopeMode.SetActive(false);
        }
        /*if (Input.GetMouseButton(1))
        {
            scopeMode.SetActive(true);
            sniperScopeView.SetActive(true);
            secondPersonView.SetActive(false);
        }
        else
        {
            scopeMode.SetActive(false);
            sniperScopeView.SetActive(false);
            secondPersonView.SetActive(true);
        }*/
    }
}
