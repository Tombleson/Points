using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript2 : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public int speedIncrease = 0;


    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 5;
        scoreText.text = playerScore.ToString();
    }

    public void increaseSpeed()
    {
        speedIncrease = speedIncrease + 10;
    }
}