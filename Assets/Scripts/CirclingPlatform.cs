using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclingPlatform : MonoBehaviour
{

    [SerializeField]
    Transform rotationCenter;

    [SerializeField]
    float rotationRadius = 2f, angularSpeed = 2f;

    float posX, posY, angle = 0f; 
   
    void Update()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * angularSpeed;

        if(angle >= 360)
        {
            angle = 0;
        }

    }
}
