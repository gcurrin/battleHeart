using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class unitStats : MonoBehaviour
{
    Health healthScript;
    [SerializeField] UnitClass unitClass;

    
    [Range(1, 25)] public int currentLevel;

    public Stats stats;
    public Stats classStats;
    public Stats itemStats;
    
    private void Start()
    {
        generateStats();
        Debug.Log(stats);
        healthScript = GetComponent<Health>();
        healthScript.setup(stats);


    }

    void generateStats()
    {
        //class stats
        classStats = unitClass.getStats(currentLevel);
        //equipment bonuses
        itemStats = new Stats();
        stats = classStats + itemStats;

    }
   

    public Sprite getClassImage() {
        return unitClass.classImage;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
