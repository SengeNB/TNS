using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarScript : MonoBehaviour
{
    public float progressBarSpeed;
    public Rigidbody2D mySixthRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mySixthRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        mySixthRigidbody.AddForce(transform.right * progressBarSpeed, ForceMode2D.Impulse);
    }
}
