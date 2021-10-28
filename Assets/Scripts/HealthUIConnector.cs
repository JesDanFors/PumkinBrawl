using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIConnector : MonoBehaviour
{

    public Text healtText;
    
    private int player1Health;
    private PlayerHealth[] players;
    public string player = "p_Player_P1";
    private void Start()
    {
        players = FindObjectsOfType<PlayerHealth>();
    }

    private void Update()
    {
        
        foreach (var VARIABLE in players)
        {
            if (VARIABLE.gameObject.name == player)
            {
                player1Health = VARIABLE._health;
            }
            
        }
        int currenthp = player1Health;
        healtText.text = $"{currenthp}%";
    }
}
