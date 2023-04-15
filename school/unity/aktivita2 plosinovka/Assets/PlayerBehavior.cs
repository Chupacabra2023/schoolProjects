using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    private int movementSpeed;

    new private Rigidbody2D rigidbody;

    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float groundCheckRadius;

    [SerializeField]
    private LayerMask groundLayer;

    private bool isGrounded;
    private int doubleJump;
    public Animator animatior;
    private SpriteRenderer spi;
    private bool check;

    void Start()
    {
        isGrounded = false;
       

        rigidbody = GetComponent<Rigidbody2D>();
        spi = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rigidbody.velocity.y);
        animatior.SetFloat("speed", Math.Abs(Input.GetAxis("Horizontal") * movementSpeed));
        if (Input.GetAxis("Horizontal") >= 0)
        {
            spi.flipX = false;
        }
        else
        {
            spi.flipX = true;
        }

        // Check if the player is grounded

      //  isGrounded = Physics2D.OverlapCircle(transform.position - new Vector3(0, 0.5f, 0), groundCheckRadius, groundLayer);
       
    }

     void Update()
    {
        if (isGrounded)
        {
          
       
            doubleJump = 2;
            animatior.SetBool("isJumping", false);
            animatior.SetBool("isJumpingTwice", false);

    }
              

        if (Input.GetButtonDown("Jump") && doubleJump > 0 )
        {
            animatior.SetBool("isJumping", true);
            isGrounded = false;

            if (doubleJump == 1)
            {
                animatior.SetBool("isJumpingTwice", true);
                animatior.SetBool("isJumping", false);
            }
            else
            {
             
              //  animatior.SetBool("isJumpingTwice", false);
            }
            

            doubleJump -= 1;

            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded= true;
        }
    }
}