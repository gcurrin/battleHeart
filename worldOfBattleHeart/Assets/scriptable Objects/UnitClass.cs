using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newClass", menuName = "ScriptableObjects/newClass")]
public class UnitClass : ScriptableObject
{
    public Sprite classImage;
    public string className;
    public heroType primaryStat;
    [Header("Base stats")]
    public int basePower; 
    public int baseStrength;
    public int baseAgility;
    public int baseIntelligence;
    public int baseHealth;
    public int baseArmor;
    


    [Header("Growths")]
    public float powerGrowth;
    public float strengthGrowth;
    public float agilityGrowth;
    public float intelligenceGrowth;
    public float healthGrowth;
    public float armorGrowth;

    


    public Stats getStats( int level)
    {
        Stats baseStats = new Stats(basePower,baseStrength,baseAgility,baseIntelligence,baseHealth,baseArmor);
        Stats levelBonus = new Stats(powerGrowth, strengthGrowth, agilityGrowth, intelligenceGrowth, healthGrowth, armorGrowth, level);
        return baseStats + levelBonus;
    }

    
}


public enum heroType
{
    Strength,
    Agility,
    Intelligence,
    Special
}


