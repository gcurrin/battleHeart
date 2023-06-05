using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{

    public Loader.Scenes chosenLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void loadBattle()
    {
        Loader.LoadLevel(Loader.Scenes.Battle);
    }
}
