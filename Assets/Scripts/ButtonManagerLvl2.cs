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

    public void startWait1Second()
    {
        StartCoroutine(wait1Second());

    }

    IEnumerator wait1Second()
    {

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Level_2");

    }

    public void startMenuWait1Second()
    {
        StartCoroutine(waitMenu1Second());

    }

    IEnumerator waitMenu1Second()
    {

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainMenu");

    }
}
