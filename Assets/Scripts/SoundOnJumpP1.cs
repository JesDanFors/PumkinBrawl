using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnJumpP1 : MonoBehaviour
{
    private Rigidbody2D rb;
    public string jumped = "VerticalP1";
    
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown(jumped))
        {
            SoundControlP1.SndMan.PlayJumpSounds();
        }
    }
}
