using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public Image fade;

    //Fade to black. Change second value for amount of seconds. 
    public void FadeOnButtonPress()
    {

        fade.CrossFadeAlpha(1, 3, false);

    }

    public void Start()
    {
        fade.canvasRenderer.SetAlpha(0.0f);
    }

    public void LoadScene1()
    {

        SceneManager.LoadScene("Level_1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Level_2");
    }

    //Waiting time until new scene loads. Change (value) for seconds. 
    public void startWaitLevel1()
    {

        StartCoroutine(WaitForLevel1());
    }

    IEnumerator WaitForLevel1()
    {

        yield return new WaitForSeconds(3);
        LoadScene1();

    }

    public void startWaitLevel2()
    {
        StartCoroutine(WaitForLevel2());
    }

    IEnumerator WaitForLevel2()
    {

        yield return new WaitForSeconds(3);
        LoadScene2();

    }
}


