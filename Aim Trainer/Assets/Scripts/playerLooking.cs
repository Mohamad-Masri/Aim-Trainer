using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLooking : MonoBehaviour
{
    float mouseSensitivity = 100f;

    public Transform xView;
    void Start()
    {
    
    }

    void Update()
    {
        float mouseX = Input.GetAxis("MouseX") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("MouseY") * mouseSensitivity * Time.deltaTime;


        xView.Rotate(Vector3.up * mouseX);
    }
}
