using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBiggerPaddle : AbstractPowerUps
{
    // Start is called before the first frame update
    void Start()
    {
        paddle = GameObject.FindGameObjectWithTag("Paddle");
        Rigidbody2D force = gameObject.GetComponent<Rigidbody2D>();
        force.AddForce(new Vector2(0, -150));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        public void activate()
        {
       
            paddle.transform.transform.localScale += (new Vector3(1,0,0));
            Invoke("deactivate", 20f);
           gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
        public void deactivate()
        {
            paddle.transform.transform.localScale += (new Vector3(-1, 0, 0));
            Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Paddle"))
        {
            activate();
        }
    }
}
