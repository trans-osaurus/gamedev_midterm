﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float moveSpeed = 10f;

    public float maxSpeed;
    //this variable remembers input and passes it to physics
    private Vector3 inputVector;

    private Rigidbody rb;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update () {
        
        //cursor locked to the center of the screen
        //if (Input.GetMouseButtonDown(0)) //0 = left, 1 = right, 2 = middleclick
        //{
     //       Cursor.lockState = CursorLockMode.Locked;
       //     Cursor.visible = false;
       // }
        
        //mouselook. these r mouse deltas / differences between different frames
        //0 when nothing is moving. this ISNT MOUSE POSITION
        float mouseX = Input.GetAxis("Mouse X"); //horizontal mouse movement
        float mouseY = Input.GetAxis("Mouse Y"); //vertical
        
        //rotate the camera based on mouse input
        //pitch: up and down rotation (x axis) yaw = left and right rotation (Y axis) roll = rolling (z axis)
        //first rotate body based on horizontal mouse movement
        transform.Rotate( 0f, mouseX * 2, 0f);
        Camera.main.transform.Rotate(-mouseY * 2, 0f, 0f);

        
        //WASD MOVEMENT
        //get axiss returns a float between -1f and 1f. when you're not pressing anything it returns 0f
        float horizontal = Input.GetAxis("Horizontal"); // a d
        float vertical = Input.GetAxis("Vertical"); // w s
        //apply keyboard input to position
        //when you do this, you're teleporting. no collision detection
        //transform.position += transform.forward * vertical * moveSpeed; //forward
        //transform.position += transform.right * horizontal * moveSpeed; //strafe
      

        //collecting data. remember to use += so it means 'also equals' i guess??
        inputVector = transform.forward * vertical;
        inputVector += transform.right * horizontal;
        

    }
//runs every physics frame (a different framerate than input or rendering or anything else)
//PUT ALL PHYSICS CODE IN FIXEDUPDATE
    void FixedUpdate()
    {
        //override object's velocity with desired inputVector direction
        rb.velocity += inputVector * moveSpeed;
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

    }
}