using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Image[] Health;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
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

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            
        }
    }

    public void AddHealth(int amount)
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += amount;
        }
    }

}
