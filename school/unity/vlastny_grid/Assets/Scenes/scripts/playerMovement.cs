using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    private float moveSpeed = 1;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
       

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDelta = new Vector3(x, y, 0);

        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);



        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 2;
        }
        else
            moveSpeed = 1;
       






        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y*moveSpeed), Mathf.Abs((moveDelta.y * Time.deltaTime) * moveSpeed), LayerMask.GetMask("collision mask"));
        if(hit == false)
        {
           
                transform.Translate(0, (moveDelta.y * Time.deltaTime) * moveSpeed, 0);
           
            
           
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x*moveSpeed,0), Mathf.Abs((moveDelta.x * Time.deltaTime) * moveSpeed), LayerMask.GetMask("collision mask"));
        if (hit == false)
        {
           transform.Translate((moveDelta.x * Time.deltaTime)* moveSpeed , 0,0);
        }

    }
}
