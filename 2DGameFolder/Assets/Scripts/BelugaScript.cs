using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BelugaScript : MonoBehaviour
{
    public float belugaSpeedHorizontal;
    public float belugaSpeedVertical;
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public bool belugaIsAlive = true;
    public int maxHealth = 5;
    public int currentHealth;
    public Image[] Health;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    Vector2 myMoveInput = Vector2.zero;
    public AudioSource deathSFX;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int index = 0; index < Health.Length; index++)
        {
            if (index < maxHealth)
            {
                Health[index].enabled = true;
            }
            else
            {
                Health[index].enabled = false;
            }

            if (index < currentHealth)
            {
                Health[index].sprite = fullHeart;
            }
            else
            {
                Health[index].sprite = emptyHeart;
            }
        }
    }

    private void FixedUpdate() 
    {
        if(belugaIsAlive == true) {
            //Allows Player to move Beluga Whale Up and Down
            myRigidbody.velocity = myMoveInput * belugaSpeedVertical;

            //Automatically moves Beluga Whale to the right
            myRigidbody.AddForce(transform.right * belugaSpeedHorizontal, ForceMode2D.Impulse);
        }
    }

    void OnMove(InputValue value) 
    {
        // Takes values for either up inputs or down inputs
        myMoveInput = value.Get<Vector2>();
    }

   public void BelugaDies()
    {
        belugaSpeedHorizontal = 0;
        belugaSpeedVertical = 0;
        belugaIsAlive = false;
        deathSFX.Play();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            logic.GameOver();
            belugaIsAlive = false;
            deathSFX.Play();
        }
    }

    public void AddHealth(int amount)
    {
        if(currentHealth < maxHealth)
        {
            currentHealth += amount;
        }
    }
    public void CaughtInNet()
    {
        belugaSpeedHorizontal = 0;
        belugaSpeedVertical = 0;
    }

    public void OilSlowdown()
    {
        belugaSpeedHorizontal -= 0.02f;
        belugaSpeedVertical -= 0.02f;
    }

    public void IncreaseSpeed()
    {
        belugaSpeedHorizontal += 2f;
        belugaSpeedVertical += 2f;
    }
}
