﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VsGoku : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    private int playerChoice;
    private int computerChoice;

    public TextMeshProUGUI P1Wins;
    public int Player1Wins;

    public TextMeshProUGUI P2Wins;
    public int Player2Wins;

    void Start()
    {
        resultText.text = "Choose صخر, ورق, or مقص";
        //P1Wins = GetComponent<TextMeshProUGUI>();
        Player1Wins = 0;
        Player2Wins = 0;
    }

    public void ChooseRock()
    {
        playerChoice = 0;
        PlayGame();
    }

    public void ChoosePaper()
    {
        playerChoice = 1;
        PlayGame();
    }

    public void ChooseScissors()
    {
        playerChoice = 2;
        PlayGame();
    }

    private void PlayGame()
    {
        computerChoice = Random.Range(0, 3);
        string[] choices = { "صخر", "ورق", "مقص" };
        string result;

        if (playerChoice == computerChoice)
        {
            result = "It's a tie!";
        }
        else if ((playerChoice == 0 && computerChoice == 2) ||
                 (playerChoice == 1 && computerChoice == 0) ||
                 (playerChoice == 2 && computerChoice == 1))
        {
            result = "You win!";
            P1Wins.text = Player1Wins.ToString();
            Player1Wins++;
        }
        else
        {
            result = "The Prophet wins!";
            P2Wins.text = Player2Wins.ToString();
            Player2Wins++;
        }

        resultText.text = "You chose " + choices[playerChoice] + ", The Prophet chose " + choices[computerChoice] + ". " + result;
    }

    private void Update()
    {
        if (Player1Wins >= 15)
        {
            SceneManager.LoadScene("RockPaperScissorsTest");
        }
        if (Player2Wins >= 15)
        {
            SceneManager.LoadScene("RockPaperScissorsTest");
        }
    }
}
