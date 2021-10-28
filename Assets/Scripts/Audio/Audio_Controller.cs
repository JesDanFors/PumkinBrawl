using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Controller : MonoBehaviour
{
    public Audio_Container[] containers;
    [Header("Randomize")]
    public bool randomize = false;
    public void PlayController()
    {
        if (randomize)
        {
            int r = Random.Range(0, containers.Length);
            containers[r].source.Play();
        }
        else
        {
            for (int i = 0; i < containers.Length; i++)
            {
                containers[i].source.Play();
            }
        }
    }
    public void StopController()
    {
        for (int i = 0; i < containers.Length; i++)
        {
            containers[i].source.Stop();
        }
    }
}
