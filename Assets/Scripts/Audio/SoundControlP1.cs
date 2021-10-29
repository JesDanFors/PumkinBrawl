using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControlP1 : MonoBehaviour
{
    public static SoundControlP1 SndMan;
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

    public void PlayJumpSounds()
    {
        random = Random.Range(0, 3);
        audioSrc.PlayOneShot(jumpSounds[random]);
    }
}
