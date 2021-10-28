using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Trigger : MonoBehaviour
{
    public Audio_Controller[] controllers;
    public void PlayTrigger(int playInd)
    {
        controllers[playInd].PlayController();
    }
    public void StopTrigger (int playInd)
    {
        controllers[playInd].StopController();
    }
}
