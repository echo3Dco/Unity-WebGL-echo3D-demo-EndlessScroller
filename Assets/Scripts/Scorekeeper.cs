using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script keeps score of fish eaten and manages the UI
public class Scorekeeper : MonoBehaviour
{
    private int currentScore = 0;

    public void IncrementScore()
    {
        //Adds score value to zero, adds forever, creates a string on UI predecessing the score count
        currentScore++;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Fish : " + currentScore.ToString();
    }
}
