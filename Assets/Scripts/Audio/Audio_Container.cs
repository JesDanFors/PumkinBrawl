using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Container : MonoBehaviour
{
    public AudioSource source;
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
}
