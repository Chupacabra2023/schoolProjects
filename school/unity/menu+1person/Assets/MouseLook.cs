using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float XRotation = 0;
    float YRotation = 0;
    public Transform playerBody;
    public int mouseSensitivity;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        XRotation -= MouseY;
        XRotation = Mathf.Clamp(XRotation, -90, 90);
        YRotation += MouseX;

        //playerBody.Rotate(Vector3.up* MouseX);
        playerBody.rotation = Quaternion.Euler(0, YRotation, 0);
        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
        
    }
}
