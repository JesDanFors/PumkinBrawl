using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public Image fade;

    public void Start()
    {
        fade.canvasRenderer.SetAlpha(0.0f);
    }

    public void LoadScene1()
    {

        new WaitForSeconds(3);
        SceneManager.LoadScene("Level_1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void FadeOnButtonPress()
    {

        fade.CrossFadeAlpha(1, 3, false);

    }
}


