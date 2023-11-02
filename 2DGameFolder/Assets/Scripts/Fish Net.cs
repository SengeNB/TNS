using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishNet : MonoBehaviour
{
    public BelugaScript beluga;
    public AudioSource fishnetSFX;

    // Start is called before the first frame update
    void Start()
    {
        beluga = GameObject.FindGameObjectWithTag("Player").GetComponent<BelugaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Beluga Whale Main Character"))
        {
            beluga.CaughtInNet();
            fishnetSFX.Play();
        }
    }

}
