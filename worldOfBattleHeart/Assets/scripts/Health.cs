using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int shield;
    public int maxHealth;
    floatingHealthBar healthBar;
    public int armor;
    public int magicResist;

    public enum DamageType {
        physical,
        magic,
        pure
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    
    public void setup(Stats unitStats)
    {
        maxHealth = unitStats.getMaxHP();
        armor = unitStats.armor;
        magicResist = unitStats.magicResist;
        currentHealth = maxHealth;
        healthBar = GetComponentInChildren<floatingHealthBar>();
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
    }

    public void takeDamage(int damage, DamageType type) {
        if(type == DamageType.physical)
        {
            damage = physicalDamage(damage);
        }else if(type == DamageType.magic){
            damage = magicalDamage(damage);
        }
        damage = shieldCheck(damage);
        currentHealth -= damage;
        healthBar.UpdateHealthBar(currentHealth, maxHealth);
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            handleDeath();
        }
    }

    //TODO: change armor formula
    public int physicalDamage(int damage)
    {
        return damage/armor;
    }

    public int magicalDamage(int damage)
    {
        float magicDamage = damage * ((100 - magicResist) / 100);
        Mathf.Clamp(magicDamage, 1, 2*damage);
        return (int)magicDamage;
    }

    public int shieldCheck(int damage)
    {
        if (damage > shield) {
            int temp = shield;
            shield = 0;
            return damage - temp;
        }
        else
        {
            shield -= damage;
            return 0;
        }
    }

    public void heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth) currentHealth = maxHealth;
    }

    


    void handleDeath()
    {
        Destroy(gameObject);
    }

}
