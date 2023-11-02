using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float cameraSpeedHorizontal;
    public Rigidbody2D mySecondRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        mySecondRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void FixedUpdate() 
    {
        // Moves the camera during the game
        mySecondRigidbody.AddForce(transform.right * cameraSpeedHorizontal, ForceMode2D.Impulse);
    }
}
