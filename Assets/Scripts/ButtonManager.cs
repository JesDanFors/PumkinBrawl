using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
    


public class ButtonManager : MonoBehaviour
{


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgainLevel1()
    {

        SceneManager.LoadScene("Level_1");

    }

    public void gotoMainMenu()
    {

        SceneManager.LoadScene("MainMenu");

    }
}
