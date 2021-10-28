using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 250;
    [SerializeField] string winnerScene;

    private int _health;

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
                _health -= 5;
                Debug.Log(_health);
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
