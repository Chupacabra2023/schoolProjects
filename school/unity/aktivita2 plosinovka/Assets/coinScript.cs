using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{

   // [SerializeField]
    gameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
       gameManager = FindObjectOfType<gameManagerScript>();
        Debug.Log(gameManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
         //   gameManager = GameObject.FindObjectOfType<gameManagerScript>();
            gameManager.getCoinList().Add(this);
            Debug.Log(gameManager.getCoinList().Count);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
       
    }
}
