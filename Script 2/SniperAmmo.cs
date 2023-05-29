using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SniperAmmo : MonoBehaviour
{
    Text currentAmmo;
    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void FireAmmo(int ammo)
    {
        currentAmmo.text = ammo.ToString();

    }
}
