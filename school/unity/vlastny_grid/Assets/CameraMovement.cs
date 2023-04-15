using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public float boundX = 0.15f;
    public float boundY = 0.15f;
    // Update is called once per frame
    void Update() 
    {
        Vector3 cameraDistance = Vector3.zero;
        float deltaX = playerTransform.position.x - transform.position.x; 

        if(deltaX > boundX || deltaX < -boundX)
        {
            if(transform.position.x < playerTransform.position.x)
            {
                cameraDistance.x = deltaX -  boundX ; ;
            }
            else
            {
                cameraDistance.x = deltaX + boundX;
 
            }
        }

        float deltaY = playerTransform.position.y - transform.position.y;
        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < playerTransform.position.y)
            {
                cameraDistance.y = deltaY - boundY ;
            }
            else
            {
                cameraDistance.y  = deltaY + boundY;
            }
        }

        transform.position += new Vector3(cameraDistance.x, cameraDistance.y, 0);
    }
}
