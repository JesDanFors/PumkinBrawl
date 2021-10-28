using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 250;

    private int _health;

    private void Start()
    {
        _health = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
            
            if (other.gameObject.CompareTag("Projectile"))
            {
                if (other.relativeVelocity.magnitude > 2)
                {
                    _health -= 20;
                    Debug.Log("ouch");
                }
            }
        
    }
}
