using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControlP2 : MonoBehaviour
{
    public static SoundControlP2 SndMan;
    private AudioSource audioSrc;
    private AudioClip[] jumpSounds;
    private int random;
    public string jumper = "JumpSoundsP1";

    void Start()
    {
        SndMan = this;
        audioSrc = GetComponent<AudioSource>();
        jumpSounds = Resources.LoadAll<AudioClip>(jumper);
    }

    public void PlayJumpSoundsP2()
    {
        random = Random.Range(0, 3);
        audioSrc.PlayOneShot(jumpSounds[random]);
    }
}
