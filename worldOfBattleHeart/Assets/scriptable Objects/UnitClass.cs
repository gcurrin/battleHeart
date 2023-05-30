using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newClass", menuName = "ScriptableObjects/newClass")]
public class UnitClass : ScriptableObject
{
    public string className;
    [Header("Base stats")]
    public int baseStrength;
    public int baseAgility;
    public int baseIntelligence;
    public int baseHealth;
    public int baseArmor;


    [Header("Growths")]
    public float strengthGrowth;
    public float agilityGrowth;
    public float intelligenceGrowth;
    public float healthGrowth;
    public float armorGrowth;


    public statsStruct getStats( int level)
    {
        statsStruct baseStats = new statsStruct(baseStrength,baseAgility,baseIntelligence,baseHealth,baseArmor);
        statsStruct levelBonus = new statsStruct(strengthGrowth, agilityGrowth, intelligenceGrowth, healthGrowth, armorGrowth, level);
        return baseStats + levelBonus;
    }

    
}





