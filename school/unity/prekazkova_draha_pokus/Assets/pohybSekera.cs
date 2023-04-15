using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybSekera : MonoBehaviour
{
    float speed=0.1f;
    bool a = true;
    void Start()
    {
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
     if (transform.position.x > 4)
        {
            a = false;
            speed = speed - (0.1f * (Time.deltaTime));
            Vector3 dream = transform.position + new Vector3(speed * (Time.deltaTime), 0, 0);
            Vector3 final = Vector3.Lerp(transform.position,dream,0.125f);
            transform.position = final;

        }
        if (transform.position.x < -4)

        {
            speed = speed + (0.1f * (Time.deltaTime));
            Vector3 dream = transform.position + new Vector3(speed * (Time.deltaTime), 0, 0);
            Vector3 final = Vector3.Lerp(transform.position, dream, 0.15f);
            transform.position = final;
        }
        a = true;






    }
    private void Update()
    {
        
    }
}
