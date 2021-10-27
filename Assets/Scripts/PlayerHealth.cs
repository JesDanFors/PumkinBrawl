using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 250;

    private int health;

    private void Start()
    {
        health = maxHealth;
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider);
        if (other.gameObject.CompareTag("Projectile"))
        {
            //if (other.relativeVelocity.magnitude != 0)
            //{
                health -= 20;
                Debug.Log("ouch");
            //}
        }
    }
}
