using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControlP1 : MonoBehaviour
{
    public static SoundControlP1 SndMan;
    private AudioSource audioSrc;
    private AudioClip[] jumpSounds;
    private AudioClip[] damageSounds;
    private AudioClip shootSound;
    private int random;
    public string jumper = "JumpSoundsP1";

    void Start()
    {
        SndMan = this;
        audioSrc = GetComponent<AudioSource>();
        jumpSounds = Resources.LoadAll<AudioClip>(jumper);
        damageSounds = Resources.LoadAll<AudioClip>("DamageSoundsP1");
        shootSound = Resources.Load<AudioClip>("ShootSoundP1");
    }

    public void PlayJumpSounds()
    {
        random = Random.Range(0, 3);
        audioSrc.PlayOneShot(jumpSounds[random]);
    }

    public void PlayDamageSounds()
    {
        random = Random.Range(0, 4);
        audioSrc.PlayOneShot(damageSounds[random]);
    }

    public void PlayShootSound()
    {
        audioSrc.clip = shootSound;
        audioSrc.loop = true;
        audioSrc.Play();
    }
}
