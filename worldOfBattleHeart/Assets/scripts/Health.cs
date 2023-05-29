using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage) {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            handleDeath();
        }
    }

    void handleDeath()
    {
        Destroy(gameObject);
    }

}
