using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearWasteScript : MonoBehaviour
{
    public BelugaScript beluga;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        beluga = GameObject.FindGameObjectWithTag("Player").GetComponent<BelugaScript>();
        GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Beluga Whale Main Character"))
        {
            beluga.TakeDamage(3);
            logic.GameOver();
            beluga.BelugaDies();
        }
    }
}
