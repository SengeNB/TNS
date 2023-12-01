// Written by Jason Tran

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    public GameObject weapon;
    private float xRotation = 0f;
    public float xSensitivity = 30f;
    public float ySensitivity = 30f;
    
    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        // Calculates the camera rotation for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -0f, 0f);

        // Applies this to our camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // Applies this to our weapon transform
        //weapon.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // Rotates the player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
