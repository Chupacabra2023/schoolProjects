using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool gameHadEnded = false;

    public GameObject completeLevelUI;

     //Start is called before the first frame update
    public void CompleteLevel()
    {
       completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHadEnded == false)
        {
            gameHadEnded = true;
            UnityEngine.Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
