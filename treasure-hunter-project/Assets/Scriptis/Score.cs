using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreDisplay;
    public bool shouldReset = false;
    private static int scoreValue = 0;

    private void Start()
    {
        if (shouldReset == true)
        {
            scoreValue = 0;
        }
        scoreDisplay.text = scoreValue.ToString();
    }


    public void AddScore(int toAdd)
    {
        scoreValue = scoreValue + toAdd;

        scoreDisplay.text = scoreValue.ToString();

    }
}
