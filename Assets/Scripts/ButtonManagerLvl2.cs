using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ButtonManagerLvl2 : MonoBehaviour
{


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayAgainLevel2()
    {

        SceneManager.LoadScene("Level_2");

    }

    public void gotoMainMenu()
    {

        SceneManager.LoadScene("MainMenu");

    }
}
