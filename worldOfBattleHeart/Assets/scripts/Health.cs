using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    floatingHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponentInChildren<floatingHealthBar>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.UpdateHealthBar(currentHealth, maxHealth);

    }

    public void takeDamage(int damage) {
        currentHealth -= damage;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        if(currentHealth <= 0)
        {
            handleDeath();
        }
    }

    void maxhealthChance(int changeAmount) {

    }


    void handleDeath()
    {
        Destroy(gameObject);
    }

}
