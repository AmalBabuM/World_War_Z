using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class Aiming : MonoBehaviour
{
    RaycastWeapon weapon;
    public Rig aimLayer;
    public float aimDuration = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        weapon = GetComponentInChildren<RaycastWeapon>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            aimLayer.weight += Time.deltaTime / aimDuration;
        }
        else
        {
            aimLayer.weight-= Time.deltaTime / aimDuration;
        }
        
    }
}
