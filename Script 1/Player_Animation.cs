using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation : MonoBehaviour
{
    Animator anim;
    float vVelocity=0.0f;
    float hVelocity=0.0f;   
    public float speed=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool walk = Input.GetKey("w");
        bool walkBack = Input.GetKey("s");
        bool walkRight = Input.GetKey("d");
        bool walkLeft = Input.GetKey("a");
        bool run = Input.GetKey("left shift");

        if (walk&& vVelocity<1)
        {
            vVelocity += speed * Time.deltaTime;
        }
        else if (!walk&&vVelocity>0)
        {
            vVelocity -= speed * Time.deltaTime;
        }
        if (walkBack && vVelocity > -1)
        {
            vVelocity -= speed * Time.deltaTime;
        }
        else if (!walkBack && vVelocity < 0)
        {
            vVelocity += speed * Time.deltaTime;
        }
        if (walkRight && hVelocity < 1)
        {
            hVelocity += speed * Time.deltaTime;
        }
        else if (!walkRight && hVelocity > 0)
        {
            hVelocity -= speed * Time.deltaTime;
        }
        if (walkLeft && hVelocity > -1)
        {
            hVelocity -= speed * Time.deltaTime;
        }
        else if (!walkLeft && hVelocity < 0)
        {
            hVelocity += speed * Time.deltaTime;
        }

        //RUNNING
        if (walk && run && vVelocity<2)
        {
            vVelocity += speed * Time.deltaTime;
        }
        else if (walk && !run && vVelocity > 1)
        {
            vVelocity -= speed * Time.deltaTime;
        }
        if (walkRight && run && hVelocity < 2)
        {
            hVelocity += speed * Time.deltaTime;
        }
        else if ((walkRight && !run) && hVelocity > 1)
        {
            hVelocity -= speed * Time.deltaTime;
        }
        if (walkLeft && run && hVelocity > -2)
        {
            hVelocity -= speed * Time.deltaTime;
        }
        else if ((walkLeft && !run) && hVelocity < -1)
        {
            hVelocity += speed * Time.deltaTime;
        }

        //JUMP
        if (Input.GetButtonDown("Jump")) 
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        anim.SetFloat ("vVelocity", vVelocity);
        anim.SetFloat("hVelocity", hVelocity);

    }
}
