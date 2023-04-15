using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class BallsManager : MonoBehaviour
{
    [SerializeField]
    public Ball ball;
    public GameObject paddle;
    private Ball initialBall;
    private Rigidbody2D initialBallRB;
    private List<Ball> balls;
 

    [SerializeField]
    public GameManager gameManager;
    [SerializeField]
    private GameObject beginScreen;
    private TextMeshProUGUI myTextMeshPro;

    private GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
        GameObject pointsTextObject = GameObject.Find("Life");


        endScreen = GameObject.Find("GameOver");
        myTextMeshPro = pointsTextObject.GetComponent<TextMeshProUGUI>();
        Debug.Log(endScreen);

        endScreen.SetActive(false);
        balls = new List<Ball>();
       

        InitBall();
    }

    public void InitBall()
    {
        
        Vector3 paddlePosition = paddle.transform.position;
        Vector3 ballPosition = new Vector3(paddlePosition.x, paddlePosition.y + 1.5f,0);
        initialBall = Instantiate(ball, ballPosition, Quaternion.identity);
        Debug.Log("PRVE ");
       

        initialBallRB = initialBall.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameStarted() == false) { 
         Vector3 paddlePosition = paddle.transform.position;
           Vector3 ballPosition = new Vector3(paddlePosition.x, paddlePosition.y + 0.5f, 0);
            if(balls.Count <= 0)
           initialBall.transform.position = ballPosition;
            

        if (Input.GetButton("Jump"))
        {
            beginScreen.SetActive(false);
            balls.Add(initialBall);
            initialBallRB.isKinematic= false;
            initialBallRB.AddForce(new Vector2(0, 850));
            gameManager.setGameStarted(true);
            }
        }

        if (int.Parse(myTextMeshPro.text) == 0)
        {
            endScreen.SetActive(true);
            Time.timeScale = 0f; //
        }
    }

        public List<Ball> getListOfBalls()
        {
            return balls;
        }

    public void createBalls()
    {
        List<Ball> newBalls = new List<Ball>();
        foreach (Ball b in balls)
        {
            for (int i = 0; i < 3; i++)
            {
                Ball newBall = Instantiate(ball, b.transform.position, Quaternion.identity);
               
                initialBallRB = newBall.GetComponent<Rigidbody2D>();
                initialBallRB.AddForce(new Vector2(UnityEngine.Random.Range(-800f, 800f), UnityEngine.Random.Range(-800f, 800f)));
                newBalls.Add(newBall);
            }
        }
        balls.AddRange(newBalls);
    }
}

  

