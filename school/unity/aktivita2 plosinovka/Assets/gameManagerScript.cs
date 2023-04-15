using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour
{
    [SerializeField]
    public TMP_Text textObject;
    [SerializeField]
    public TMP_Text maxPoints;
    private coinScript[] coinAmount;

    private List<coinScript> coins;
    // Start is called before the first frame update
    void Start()
    {
        coins= new List<coinScript>();
        coinAmount = FindObjectsOfType<coinScript>();
        maxPoints.text = coinAmount.Length.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if(coins.Count == coinAmount.Length)
        {
            SceneManager.LoadScene("level2");
        }

        textObject.text = coins.Count.ToString();
    }

    public List<coinScript> getCoinList()
    {
        return coins;
    }
}
