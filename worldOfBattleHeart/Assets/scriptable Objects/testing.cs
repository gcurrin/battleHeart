using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    [SerializeField] private testObject test;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(test.myString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
