using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    private float launchVelocity = 700f;
    public string fire = "Fire1P1";
    private SpriteRenderer grx;
    

    private void Start()
    {
        grx = GetComponentInChildren<SpriteRenderer>();
        
    }

    private void FixedUpdate()
    {
        
        if (Input.GetButtonDown(fire))
        {
            grx.enabled = true;
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(launchVelocity,0));
            Destroy(ball,5);
        }
    }
}
