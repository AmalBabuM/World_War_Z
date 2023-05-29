using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject firstPersonView;
    public GameObject secondPersonView;
    public GameObject scopeMode;
    public GameObject sniperScopeView;
    int camMode;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            if (camMode == 1)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
            }
        }
        if (camMode == 0)
        {
            firstPersonView.SetActive(false);
            secondPersonView.SetActive(true);
           /* SecondPersonView();*/
        }
        if (camMode == 1)
        {
            firstPersonView.SetActive(true);
            secondPersonView.SetActive(false);
           /* FirstPersonView();*/
        }
       /* if (Input.GetMouseButton(1))
        {
            scopeMode.SetActive(true);
            sniperScopeView.SetActive(true);
            *//*secondPersonView.SetActive(false);*//*
        }
        else
        {
            scopeMode.SetActive(false);
            sniperScopeView.SetActive(false);
            *//*secondPersonView.SetActive(true);*//*
        }*/
    }
        /* public void FirstPersonView()
         {   
             firstPersonView.SetActive(true);
             secondPersonView.SetActive(false);

         }
         public void SecondPersonView()
         {
             firstPersonView.SetActive(false);
             secondPersonView.SetActive(true);

         }*/

    }
