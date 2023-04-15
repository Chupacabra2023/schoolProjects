using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

  //  private float defaultPaddleWidthInPixel = 200;
    private float moving;
    private float moveRange;
    private float initialBallSpeed = 800;
 
    // Start is called before the first frame update
    void Start()
    {
   
        moving = 0;
        moveRange = 0;
    }

    // Update is called once per frame
    void Update()
    {
    //    float paddleShift = (defaultPaddleWidthInPixel - (defaultPaddleWidthInPixel / 2) * this.transform.localScale.x);
     
        Vector3 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        float leftClamp = -screenBounds.x + transform.localScale.x/2 ;
        float rightClamp = screenBounds.x - transform.localScale.x/2;


        moving = moving +  Input.GetAxis("Horizontal") * 8 * Time.deltaTime;
        moving = Mathf.Clamp(moving, leftClamp, rightClamp);
        moveRange = Mathf.Clamp(moving, leftClamp, rightClamp);
        transform.position =  new Vector3(moveRange, -screenBounds.y + transform.localScale.y / 2   , 0);
        
       // transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0) * 3 * Time.deltaTime);

    }
   

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ball")
        {
            Rigidbody2D ballRb = coll.gameObject.GetComponent<Rigidbody2D>();
            Vector3 hitPoint = coll.contacts[0].point;
            Vector3 paddleCenter = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            ballRb.velocity = Vector2.zero;

            float difference = paddleCenter.x - hitPoint.x;
            if (hitPoint.x < paddleCenter.x)
            {
                ballRb.AddForce(new Vector2(-(Mathf.Abs(difference * 200)), initialBallSpeed));
            }
            else
            {
                ballRb.AddForce(new Vector2(Mathf.Abs(difference * 200), initialBallSpeed));
            }
        }

        if (coll.gameObject.CompareTag("PowerUp"))
        {
           
        }
    }
   
}
