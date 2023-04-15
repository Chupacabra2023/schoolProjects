using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


using Random = UnityEngine.Random;

public class brickScript : MonoBehaviour
{
    int[] myArray;
    [SerializeField]
    private GameObject square;

    [SerializeField]
    private PoweUps poweUps;
    private playerMovement playerMovement;

    private TextMeshProUGUI myTextMeshPro;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
     
        playerMovement = FindObjectOfType<playerMovement>();
        gameManager = FindObjectOfType<GameManager>();


        GameObject pointsTextObject = GameObject.Find("Points");

        // Get a reference to the TextMeshPro component on the pointsText object
        myTextMeshPro = pointsTextObject.GetComponent<TextMeshProUGUI>();
       
        poweUps = FindObjectOfType<PoweUps>();
        myArray = new int[100];
        for (int i = 0; i < 100; i++)
        {
            myArray[i] = i;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {

        gameManager.getListOfBrick().Remove(this.gameObject);
        Debug.Log(myTextMeshPro.text);
        string currentText = myTextMeshPro.text;

        // Convert the text value to a number (assuming it's a valid number)
        int currentValue = int.Parse(currentText);

        // Multiply the current value by a number (e.g. 2)
        int newValue = currentValue + 1;

        // Update the TextMeshPro component with the new value
        myTextMeshPro.text = newValue.ToString();
        PoweUps poweUps = GameObject.FindObjectOfType<PoweUps>();
        if (poweUps != null)
        {
            int number = myArray[Random.Range(0, myArray.Length)];
        
            if (number > 80)
            {
                List<GameObject> powerUps = poweUps.returnListOfPowers();
                if (powerUps.Count > 0)
                {
                    GameObject abs = powerUps[Random.Range(0,powerUps.Count)];
               
                    if (!this.gameObject.scene.isLoaded) return;
                    GameObject instantiatedObject = Instantiate(abs, transform.position, Quaternion.identity);
                }
            }
        }
    }
}
    
