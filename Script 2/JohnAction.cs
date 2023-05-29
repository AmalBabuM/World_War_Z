using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnAction : MonoBehaviour
{
    Animator anim;
    float vVelocity = 0.0f;
    float hVelocity = 0.0f;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        
       
        
        bool walk = Input.GetKey("w");
        bool walkBack = Input.GetKey("s");
        bool walkRight = Input.GetKey("d");
        bool walkLeft = Input.GetKey("a");
        bool run = Input.GetKey("left shift");
        bool aim = Input.GetMouseButton(1);

        //WALK
        if (walk && vVelocity < 1)
        {
            vVelocity += speed * Time.deltaTime;
        }
        else if (!walk && vVelocity > 0)
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
        //WALK


        //LEFT & RIGHT WALK
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
        //LEFT & RIGHT WALK


        //RUN
        if (walk && run && vVelocity < 2)
        {
            vVelocity += speed * Time.deltaTime;
        }
        else if (walk && !run && vVelocity > 1)
        {
            vVelocity -= speed * Time.deltaTime;
        }
        //RUN

        //LEFT & RIGHT RUN

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

        //LEFT & RIGHT RUN





        //AIMING
        if (Input.GetMouseButton(1))
        {
            anim.SetBool("Aiming", true);
        }
        else if (!Input.GetMouseButton(1))
        {
            anim.SetBool("Aiming", false);
        }
        //AIMING

        //JUMP
        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
        //JUMP
        
        anim.SetFloat("vVelocity", vVelocity);
        anim.SetFloat("hVelocity", hVelocity);





        //RUN

        //AIM AND WALK
        /*if((walk && aim) && vVelocity<3f)
        {
            vVelocity += Time.deltaTime * speed;
            Debug.Log("on");
        }
        else if ((walk && !aim) && vVelocity > 2f)
        {
            vVelocity -= Time.deltaTime * speed;
            Debug.Log("off");

        }*/

        //AIM AND WALK

        //AIM AND RUN
        /*if((walk&&run&& aim)&&vVelocity<3.0f)
        {
            vVelocity += Time.deltaTime * speed;
        }
        else if ((walk && run && !aim) && vVelocity > 2.5f)
        {
            vVelocity -= Time.deltaTime * speed;
        }*/
        //AIM AND RUN

        //AIM AND WALKBACK
        /*if (walkBack &&  aim && vVelocity > -1.5)
        {
            vVelocity -= Time.deltaTime * speed;
        }
        else if (walkBack && !aim && vVelocity < -1.0)
        {
            vVelocity += Time.deltaTime * speed;
        }*/
        //AIM AND WALKBACK



    }
}
