   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player_Movement : MonoBehaviour
{
    CharacterController controller;
    Vector3 move;
    public float walkVelocity = 1.5f;
    public float runVelocity = 3f;

    public float jumpForce = 10f;
    public float gravity = -10f;
    Vector3 velocity= Vector3.zero;
    public float rotationSpeed;

    Camera mainCamera;
    float turnSpeed = 15f;
    /*public Transform cameraTransform; //CAMERA*/
    // Start is called before the first f rame update
    void Start()
    {
       controller= GetComponent<CharacterController>();
        mainCamera= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        float yawCamera = mainCamera.transform.rotation.eulerAngles.y;
        transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.Euler(0f,yawCamera,0f),turnSpeed*Time.deltaTime);

        float speed=Input.GetKey("left shift")? runVelocity:walkVelocity;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * y;

        controller.Move(move * speed * Time.deltaTime);

        /*if (move != Vector3.zero)
        {
            transform.forward = move;
        }*/

        if (Input.GetButtonDown("Jump"))
        {
            jump();

        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }
        controller.Move(velocity);

        /*Vector3 moveDirection=new Vector3(x, 0,y);
        moveDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * moveDirection;
        moveDirection.Normalize();
        controller.Move(moveDirection*speed*Time.deltaTime);
        if(moveDirection!=Vector3.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
            *//*transform.forward=moveDirection;*//*
        }*/

    }
    void jump()
    {
        velocity.y = jumpForce;
    }
}
