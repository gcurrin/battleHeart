using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class Loader 
{
   public enum Scenes {
        Battle,
        LoadingScene,
        MainMenu
   }

    public static void LoadLevel(Scenes targetLevel)
    {
        SceneManager.LoadScene(targetLevel.ToString());
    }
}
