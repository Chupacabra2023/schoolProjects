using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject hrac;
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(61, 251, 0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = hrac.transform.position + new Vector3(1f, 5.11f, 0.8f);
        Vector3 desiredDestinacion = Vector3.Lerp(transform.position, desiredPosition, 0.125f);
        transform.position = desiredDestinacion;
    }
}
