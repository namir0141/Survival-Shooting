
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManages : MonoBehaviour
{
    public static int score;

    TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
        score = 0;
    }

    void Update()
    {
        text.text = "Score: " + score;
        CheckAndUpdateHighScore();
    }

    void CheckAndUpdateHighScore()
    {
        if (score > HighScoreManager.HighScore)
        {
            HighScoreManager.HighScore = score;
            HighScoreManager.SaveHighScore();
        }
    }
}
