using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunSwitch : MonoBehaviour
{
    public GameObject gunAR;
    public GameObject logoAR;
    public GameObject gunSniper;
    public GameObject logoSnipe;
    int swap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            if (swap == 1)
            {
                swap = 0;
            }
            else
            {
                swap += 1;
            }
        }
        if (swap == 0)
        {
            gunAR.SetActive(false);
            logoAR.SetActive(false);
           
            gunSniper.SetActive(true);
            logoSnipe.SetActive(true);
            /* SecondPersonView();*/
        }
        if (swap == 1)
        {
            gunAR.SetActive(true);
            logoAR.SetActive(true);
           
            gunSniper.SetActive(false);
            logoSnipe.SetActive(false);
            /* FirstPersonView();*/
        }
    }

}
