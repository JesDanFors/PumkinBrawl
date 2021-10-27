using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public void LoadScene1()
    {

        SceneManager.LoadScene("Level_1");

    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Level_2");
    }
         

}


