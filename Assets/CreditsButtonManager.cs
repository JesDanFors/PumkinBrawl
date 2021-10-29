using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButtonManager : MonoBehaviour
{
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
