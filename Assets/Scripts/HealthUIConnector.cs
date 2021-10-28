using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUIConnector : MonoBehaviour
{

    public Canvas hpCanvas;
    
    private int player1Health;
    private int player2Health;
    private void Start()
    {
        PlayerHealth[] players = FindObjectsOfType<PlayerHealth>();
        foreach (var VARIABLE in players)
        {
            if (VARIABLE.gameObject.name == "p_Player_P1")
            {
                player1Health = VARIABLE._health;
            }

            if (VARIABLE.gameObject.name == "p_Player_P2")
            {
                player2Health = VARIABLE._health;
            }
        }
    }

    private void Update()
    {
        if (hpCanvas.GetComponentInChildren<Text>().name == "Player1")
        {
            string text = Convert.ToString(player1Health);
        }

        if (hpCanvas.GetComponentInChildren<Text>().name == "Player2")
        {
            string text = Convert.ToString(player2Health);
        }
            
        
    }
}
