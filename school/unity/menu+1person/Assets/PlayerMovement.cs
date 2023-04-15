using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

    {
    public CharacterController controller;
    public float speed;
    public float gravity;
    private float x, z;
    public Transform groudCheck;
    public LayerMask groundCheckMask;
    public float groundCheckRadius;
    Vector3 velocity;
    public Vector3 defaultScale;
    public Vector3 shrinkingScale;
    public Vector3 crouchingScale;
    private bool isGrounded;
    public float jumpHeight;
   

    private void Start()
    {
        
    }

    private void Update()
    {

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        isGrounded = Physics.CheckSphere(groudCheck.position, groundCheckRadius, groundCheckMask);


        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -5;
            if (Input.GetButtonDown("Jump"))
            {
                velocity.y += jumpHeight;
            }

            //THIS CODE SAIS YOU JUST NEED TO PRESS ONCE CTR OR C TO SHRINK OR CRAWL
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (transform.localScale.y > 0.2 && transform.localScale.y < 0.2001)
                {
                    print(transform.localScale.y);
                    controller.radius = (float)0.5;
                    transform.localScale = defaultScale;
                    speed = 5;
                    
                    return;

                }
                
                controller.radius = (float)0.2;
                transform.localScale = crouchingScale;
                speed = 1;
            }


            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                if (transform.localScale.y == 0.5)
                {
                    transform.localScale = defaultScale;
                    speed = 5;
                    return;

                }
                controller.radius = (float)0.5;
                transform.localScale = shrinkingScale;
                speed = 3;
            }

            //THIS CODE SAYS YOU HAVE TO KEEP PRESSED CTRL OR C TO CRAWL OR SHRINK
            /*   if (Input.GetKeyDown(KeyCode.C))
               {
                   controller.radius = (float)0.2;
                   transform.localScale = crouchingScale;
                   speed = 1;
               } else
               {
                   if (Input.GetKey(KeyCode.LeftControl))
                   {

                       transform.localScale = shrinkingScale;
                       speed = 2;

                   }
                   else
                   {
                       controller.radius = (float)0.5;
                       transform.localScale = defaultScale;
                       speed = 5;
                   }
               }*/
        }
        

        Vector3 move = (transform.right * x + transform.forward * z)* speed + velocity;
        velocity.y -= gravity;

        controller.Move(move * Time.deltaTime);
        
    }
}