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
            if (other.relativeVelocity.magnitude > 20)
            {
                _health -= 3;
            }
        }
        Death();
    }

    void Death()
    {
        if (_health <= 0)
        {
            Destroy(this);
            SceneManager.LoadScene(winnerScene);
        }
    }
}
