using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    private const string HighScoreKey = "HighScore";

    public static int HighScore
    {
        get => PlayerPrefs.GetInt(HighScoreKey, 0);
        set => PlayerPrefs.SetInt(HighScoreKey, value);
    }

    public static void SaveHighScore()
    {
        PlayerPrefs.Save();
    }
}
