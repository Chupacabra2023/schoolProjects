using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backForce = 500f;
  
    // Start is called before the first frame update
    void Start() 
    {
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")) {

           // z = z + (float)speed.z;
            
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
          //  z = z -(float)speed.z;
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey("a"))
        {
          //  x = x -(float)speed.x;
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey("s"))
        {
            //x = x+(float)speed.x;
            rb.AddForce(0, 0, -backForce * Time.deltaTime);
        }
        if (Input.GetKey("space"))
        {
            //y = y + 1;
        }
        if(rb.position.y < -2)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
       // transform.position = transform.position + new Vector3(x, y, z);
       // z = 0;
       // y = 0;
        //x = 0;
    }
}
