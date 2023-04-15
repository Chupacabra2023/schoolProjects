using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour



{
    [SerializeField]
    private GameObject brick;
    private float radius;
    private Vector3 screenBounds;
    private bool gameStarted;
    [SerializeField]
    private GameObject wall;
    private List<GameObject> bricks;
    private GameObject endScreen;
    private GameObject welcomeScreen;
    private GameObject win;

    void Start(){

        endScreen = GameObject.Find("GameOver");
        welcomeScreen = GameObject.Find("Welcome");
        win = GameObject.Find("Win");
        bricks = new List<GameObject>();
        Camera cam = Camera.main;
        float height = 2f * cam.aspect;
        float width = height * cam.aspect;
        win.SetActive(false);
        gameStarted = false;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        wall = Instantiate(wall, new Vector3(-screenBounds.x-1, 0, 0),Quaternion.identity);
        BoxCollider2D boxCollider2D = wall.GetComponent<BoxCollider2D>();
        boxCollider2D.size = new Vector3(2,height*3,0);
        wall = Instantiate(wall, new Vector3(screenBounds.x+1, 0, 0), Quaternion.identity);
        boxCollider2D = wall.GetComponent<BoxCollider2D>();
        boxCollider2D.size = new Vector3(2, height * 3, 0);

        wall = Instantiate(wall, new Vector3(0, screenBounds.y + 1, 0), Quaternion.identity);
       
        boxCollider2D = wall.GetComponent<BoxCollider2D>();
        boxCollider2D.size = new Vector3(width * 3, 2, 0);
        
        wall = Instantiate(wall, new Vector3(0, -screenBounds.y-1, 0), Quaternion.identity);
        boxCollider2D = wall.GetComponent<BoxCollider2D>();
        boxCollider2D.size = new Vector3(width * 3, 2, 0);
        wall.tag = "DeadWall";

        for (int j = 0; j < 3; j++)
        {
            for (float i = -screenBounds.x + (brick.transform.localScale.x / 2); i < screenBounds.x; i = i + brick.transform.localScale.x * 1.1f)
            {
                
                brick = Instantiate(brick, new Vector3(i, screenBounds.y - (brick.transform.localScale.x / 2) - 1 * j), Quaternion.identity);
                brick.GetComponent<SpriteRenderer>().color = new Color32((byte)(j*80),(byte)(Mathf.Abs(i)*10),1,255);
                bricks.Add(brick);
              
             
            }
        }

        Invoke("createOneMoreLayer", 5f);
        
    }
    public List<GameObject> getListOfBrick()
    {
        return bricks;
    }
    public void createOneMoreLayer()

    {
        foreach(GameObject gm in bricks)
        {
            
            if (gm.transform.position.y < -screenBounds.x+8) {
               
                welcomeScreen.SetActive(false);
                endScreen.SetActive(true);
                Time.timeScale = 0f; //
            }
            gm.transform.position += new Vector3(0, -1, 0);
        }
      
        for (float i = -screenBounds.x + (brick.transform.localScale.x / 2); i < screenBounds.x; i = i + brick.transform.localScale.x * 1.1f)
        {
            

            brick = Instantiate(brick, new Vector3(i, screenBounds.y - (brick.transform.localScale.x / 2) ), Quaternion.identity);
            brick.GetComponent<SpriteRenderer>().color = new Color32((byte)(80), (byte)(Mathf.Abs(i) * 10), 1, 255);
            bricks.Add(brick);


        }

        Invoke("createOneMoreLayer", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if(getListOfBrick().Count <= 0)
        {
            win.SetActive(true);
            Time.timeScale = 0f; //
        }
    }
    public void setGameStarted(bool statement)
    {
        gameStarted = statement;
    }
    public bool isGameStarted()
    {
        return gameStarted;
    }

    public void EngGame()
    {

    }

    public void Restart()
    {

    }
   
   
}
