using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadZoneScript : MonoBehaviour
{
    public LogicScript logic;
    public BelugaScript beluga;
    public float playerDeadZoneSpeed;
    public Rigidbody2D myFifthRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        beluga = GameObject.FindGameObjectWithTag("Player").GetComponent<BelugaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        myFifthRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        myFifthRigidbody.AddForce(transform.right * playerDeadZoneSpeed, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Beluga Whale Main Character"))
        {
            beluga.BelugaDies();
            logic.GameOver();
        }
    }
}
