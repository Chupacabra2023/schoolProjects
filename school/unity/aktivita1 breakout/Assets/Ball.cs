

using TMPro;


using UnityEngine;

public class Ball: MonoBehaviour
{


    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private BallsManager ballsManager;



    private TextMeshProUGUI myTextMeshPro;

   
   
    // Start is called before the first frame update


    private void Start()
    {
        GameObject pointsTextObject = GameObject.Find("Life");

      
        
        myTextMeshPro = pointsTextObject.GetComponent<TextMeshProUGUI>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
        ballsManager = GameObject.FindObjectOfType<BallsManager>();
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
           
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "DeadWall")
        {
          
       
            ballsManager.getListOfBalls().Remove(this);

            Debug.Log(ballsManager.getListOfBalls().Count);
            if (ballsManager.getListOfBalls().Count <= 0)
            {
               
                string currentText = myTextMeshPro.text;
                int currentValue = int.Parse(currentText);
                int newValue = currentValue - 1;
                myTextMeshPro.text = newValue.ToString();
                gameManager.setGameStarted(false);
                ballsManager.InitBall();
            }
           
            Destroy(gameObject);
        }
    }
     
}
