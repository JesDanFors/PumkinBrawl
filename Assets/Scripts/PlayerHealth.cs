using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField] string winnerScene;

    public int _health;

    private void Start()
    {
        _health = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            if (other.relativeVelocity.magnitude > 30)
            {
                _health -= 5;
                SoundControlP1.SndMan.PlayDamageSounds();
            }
        }
        Death();
    }

    void Death()
    {
        if (_health <= 0)
        {
            SceneManager.LoadScene(winnerScene);
        }
    }
}
