using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Health))]
public class Stats : MonoBehaviour
{
    Health healthScript;

    [Header("Base stats")]
    public int health;
    public int armor;

    [Header("Attributes")]
    public int strength;
    public int agility;
    public int intelligence;

    private void Awake()
    {
        healthScript = GetComponent<Health>();
        healthScript.maxHealth = 10 * strength;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
