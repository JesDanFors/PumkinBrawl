using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 1000f;
    public string fire = "Fire1P1";
    private SpriteRenderer grx;
    private float shotsPerSecond = 5.0f;
    private bool shot = false;
    

    private void Start()
    {
        grx = GetComponentInChildren<SpriteRenderer>();
        InvokeRepeating("Shoot", 0, 1 / shotsPerSecond);

    }

    void Shoot()
    {
        if (!shot)
        {
            return;
        }
        grx.enabled = true;
        GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
        ball.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(launchVelocity,0));
        Destroy(ball,5);
    }

    private void FixedUpdate()
    {
        shot = false;
        if (Input.GetButton(fire))
        {
            shot = true;
        }
    }
}
