using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHighScore : MonoBehaviour
{
    TMP_Text displayText;

    void Start()
    {
        displayText = GetComponent<TMP_Text>();
        UpdateHighScoreText();
    }

    void Update()
    {
        
        if (displayText.text != "Game Over!\nHigh Score: " + HighScoreManager.HighScore)
        {
            UpdateHighScoreText(); 
        }
    }

    void UpdateHighScoreText()
    {
        displayText.text = "Game Over!\n";
        displayText.text += "High Score: " + HighScoreManager.HighScore;
    }
}
