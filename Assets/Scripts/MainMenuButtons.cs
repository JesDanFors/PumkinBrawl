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
        fade.CrossFadeAlpha(1, 3, false);
    }

    public void LoadScene1()
    {

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

    //public void startWaitLevel1()
    //{

    //    StartCoroutine(WaitForLevel1());
    //}

    //IEnumerator WaitForLevel1()
    //{

    //    yield return new WaitForSeconds(4);
    //    LoadScene1();

    //}

    //public void startWaitLevel2()
    //{
    //    StartCoroutine(WaitForLevel2());
    //}

    //IEnumerator WaitForLevel2()
    //{

    //    yield return new WaitForSeconds(4);
    //    LoadScene2();

    //}
}


