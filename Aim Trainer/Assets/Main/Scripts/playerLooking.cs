using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLooking : MonoBehaviour
{
    public float mouseSensitivity = 130f;
    public Transform xView;
    float xRotation = 0f;


    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // X Rotation
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        xView.Rotate(Vector3.up * mouseX);

        // Y Rotation with out rotate the player
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f); // if number more than 0 the camera it self will rotate
        xRotation -= mouseY; // if we use (+) instead of (-) the mouse will rotate in the wrong side
                             // if only (=) rotation will not work

        // Clamp( the limit of Y looking)
        xRotation = Mathf.Clamp(xRotation,-90f, 90f);
    }
}