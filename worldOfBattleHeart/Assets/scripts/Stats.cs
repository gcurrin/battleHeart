using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Stats : MonoBehaviour
{
    Health healthScript;
    [SerializeField] UnitClass unitClass;
    [Header("Base stats")]
    public int currentLevel;

    public statsStruct unitStats;
    /*
    [Header("Attributes")]
    public int strength;
    public int agility;
    public int intelligence;

    [Header("Unit individual things")]
    public int level;
    */
    private void Awake()
    {
        generateStats();
        Debug.Log(unitStats);
        healthScript = GetComponent<Health>();
        healthScript.maxHealth = unitStats.health + unitStats.strength * 10;
        
        
    }

    void generateStats()
    {
        //class stats
        unitStats = unitClass.getStats(currentLevel);
        //equipment bonuses
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateHealth()
    {
        
    }
}

public struct statsStruct
{
    public int strength;
    public int agility;
    public int intelligence;
    public int health;
    public float armor;

    //constructor for bases
    public statsStruct(int s, int a, int i, int h, int arm)
    {
        strength = s;
        agility = a;
        intelligence = i;
        health = h;
        armor = arm;

    }

    //constructor for growths
    public statsStruct(float s, float a, float i, float h, float arm, int level)
    {
        level -= 1;//Adjusted so no bonuses at level 1
        strength = (int)(s * level);
        agility = (int)(a * level);
        intelligence = (int)(i * level);
        health = (int)(h * level);
        armor = (int)(arm * level);

    }

    //Add the two together
    public static statsStruct operator +(statsStruct a, statsStruct b)
    {
        statsStruct c = new statsStruct();
        c.strength = a.strength + b.strength;
        c.agility = a.agility + b.agility;
        c.intelligence = a.intelligence + b.intelligence;
        c.health = a.health + b.health;
        c.armor = a.armor + b.armor;
        return c;
    }

    //toString method change
    public override string ToString() {

        return "\nStrength: " + strength+
            "\nAgility: " + agility+
            "\nIntelligence: " + intelligence+
            "\nMax Health: " + health+
            "\nArmor: " + armor;
    }

}

