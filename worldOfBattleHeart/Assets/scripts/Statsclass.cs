using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statsclass : MonoBehaviour {

}

[System.Serializable]
public struct Stats
{
    //Stats that come from class.
    public int power;
    public int strength;
    public int agility;
    public int intelligence;
    public int health;
    public int armor;

    //stats that come from base stats or items.
    public int magicResist;
    public float critChance;
    public float dodgeChance;
    public float cooldown;
    public float statusResist;

    //constructor for bases
    public Stats(int p,int s, int a, int i, int h, int arm) : this()
    {
        power = p;
        strength = s;
        agility = a;
        intelligence = i;
        health = h;
        armor = arm;
    }

    //constructor for growths
    public Stats(float p,float s, float a, float i, float h, float arm, int level):this()
    {
        
        level -= 1;//Adjusted so no bonuses at level 1
        power = (int)(p * level);
        strength = (int)(s * level);
        agility = (int)(a * level);
        intelligence = (int)(i * level);
        health = (int)(h * level);
        armor = (int)(arm * level);
        
    }

    //Add the two together
    public static Stats operator+(Stats a, Stats b)
    {
        Stats c = new Stats();
        c.power = a.power + b.power;
        c.strength = a.strength + b.strength;
        c.agility = a.agility + b.agility;
        c.intelligence = a.intelligence + b.intelligence;
        c.health = a.health + b.health;
        c.armor = a.armor + b.armor;

        c.magicResist = a.magicResist + b.magicResist;
        c.critChance = a.critChance + b.critChance;
        c.dodgeChance = a.dodgeChance + b.dodgeChance;
        c.statusResist = a.statusResist + b.statusResist;
        c.cooldown = a.cooldown + b.cooldown;
        return c;
    }

    public int getMaxHP()
    {
        return health + (strength * 10);
    }

    //toString method change
    public override string ToString() {

        return "\nStrength: " + strength+
            "\nAgility: " + agility+
            "\nIntelligence: " + intelligence+
            "\nBase Health: " + health+
            "\nArmor: " + armor;
    }

}

