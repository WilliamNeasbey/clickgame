using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissors : MonoBehaviour
{
    public Text resultText;

    private int playerChoice;
    private int computerChoice;

    void Start()
    {
        resultText.text = "Choose Rock, Paper, or Scissors";
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
        string[] choices = { "Rock", "Paper", "Scissors" };
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
        }
        else
        {
            result = "Computer wins!";
        }

        resultText.text = "You chose " + choices[playerChoice] + ", computer chose " + choices[computerChoice] + ". " + result;
    }
}
