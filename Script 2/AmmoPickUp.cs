using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickUp : MonoBehaviour
{
    
   /* public Image[] bullet;*/

    RaycastWeapon name=new RaycastWeapon();
    RaySniper name2= new RaySniper();
    // Start is called before the first frame update
    void Start()
    {
       /* foreach(var image in bullet)
        {
            image.enabled=false;
        }*/
    }
   
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag == "Player")
        {
            /*RaycastWeapon item = other.GetComponent<RaycastWeapon>();
            item.IncreaseMag();
            other.GetComponent<RaycastWeapon>();
            item.IncreaseMag();*/
            /*Debug.Log("Hi");*/
            name.IncreaseMag();
            name2.IncreaseMag();

            Destroy(gameObject);
        }
    }

    /*public void MagAdd(int mag)
    {
        bullet[mag-1].enabled = true;
    }
    public void MagSubb(int mag)
    {
        bullet[mag - 1].enabled = false;
    }*/
}
