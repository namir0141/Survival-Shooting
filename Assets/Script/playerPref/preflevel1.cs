using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class preflevel1 : MonoBehaviour
{
    public int levelNumber; // Level number
    public GameObject screenUI;

    void Start()
    {
        DisplayLevelInfo();
    }

    void DisplayLevelInfo()
    {
        int requiredKills = PlayerPrefs.GetInt("Level" + levelNumber + "Kills", 0);

        TMP_Text textComponent = screenUI.GetComponent<TMP_Text>();
        if (textComponent != null)
        {
            textComponent.text = "Level " + levelNumber + " - Kill " + requiredKills + " Enemies";
        }
        else
        {
            Debug.LogError("Text component not found");
        }
    }


}
