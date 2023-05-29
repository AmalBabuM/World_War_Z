using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour
{
    public Image[] bullet;
    static int mag = 4;
    // Start is called before the first frame update
    void Start()
    {
        /*foreach( var image in bullet)
        {
            image.enabled = false;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyUp("o"))
        {
            mag++;
            MagAdd(mag);
        }
        if (Input.GetKeyUp("p"))
        {
            MagSub(mag);
            mag--;
            
        }*/
    }

    public void MagAdd()
    {
        /*bullet[mag-1].enabled = true;*/
        Debug.Log(mag);
    }
    public void MagSub()
    {
        /*bullet[mag-1].enabled = false;*/
        /*mag1 += 10;*/
        Debug.Log(mag);
    }
}
