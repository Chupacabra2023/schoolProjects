using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpLightBall : AbstractPowerUps
{


    private BallsManager ballsManager;

    // Start is called before the first frame update
    void Start()
    {
        ballsManager = GameObject.FindObjectOfType<BallsManager>();
        Rigidbody2D force =  gameObject.GetComponent<Rigidbody2D>();
        force.AddForce(new Vector2(0,-150));
        Debug.Log("vytvorene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void activate()
    {
        ballsManager.createBalls();

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
