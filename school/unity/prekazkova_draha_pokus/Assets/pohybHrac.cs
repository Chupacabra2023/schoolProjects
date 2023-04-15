using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybHrac : MonoBehaviour
{
    private Vector3 desiredPlace;
    private static bool moving = true;
    
    void Start()
    {

        desiredPlace = new Vector3(transform.position.x, transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            desiredPlace = new Vector3(transform.position.x - 1, this.transform.position.y, this.transform.position.z);
            movingBan();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            desiredPlace = new Vector3(transform.position.x + 1, this.transform.position.y, this.transform.position.z);
            movingBan();

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredPlace = new Vector3(transform.position.x, this.transform.position.y, this.transform.position.z - 1);
            movingBan();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredPlace = new Vector3(transform.position.x, this.transform.position.y, this.transform.position.z + 1);
            movingBan();
        }
     }

 void movingBan()
    {
        if (moving)
        {
            StartCoroutine(Lerp(desiredPlace));
            moving = false;
        }
        
    }
IEnumerator Lerp(Vector3 desiredPlace)
    {
        
        float time = 0;
        float duration = 0.5f;
        Vector3 startPosition = transform.position;
        
            
                while (time < duration)
                {
                    transform.position = Vector3.Lerp(startPosition, desiredPlace, time / duration);
                    time += Time.deltaTime;
                    yield return new WaitForFixedUpdate();
                }
                transform.position = desiredPlace;
                moving = true;
            
        

    }
}
