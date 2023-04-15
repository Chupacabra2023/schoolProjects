using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addRow : MonoBehaviour
{
    private BallsManager ballsManager;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager= GameObject.FindObjectOfType<GameManager>();
        ballsManager = GameObject.FindObjectOfType<BallsManager>();
        Rigidbody2D force = gameObject.GetComponent<Rigidbody2D>();
        force.AddForce(new Vector2(0, -150));
        Debug.Log("vytvorene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activate()
    {
       gameManager.createOneMoreLayer();

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
