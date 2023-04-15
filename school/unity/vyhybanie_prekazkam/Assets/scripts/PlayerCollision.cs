using System.Collections;
using System.Collections.Generic;

using UnityEngine;



public class PlayerCollision : MonoBehaviour
{
    
    public playerMovement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacles")
        {

            UnityEngine.Debug.Log("ahoj");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
             
        }
    }
}
