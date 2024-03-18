using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelselector : MonoBehaviour
{

    public Button[] buttons;
    private int[] requiredKillsPerLevel = { 3, 5, 7, 10, 15, 20, 25, 28, 31, 50 };
    private void Awake()
    {
        
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            
            buttons[i].interactable = false;
        }
        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
        CheckEnemyKillCount(unlockedLevel);

    }

    public void OpenLeveL(int levelID)
    {
        string levelName = "level " + levelID;
        SceneManager.LoadScene(levelName);
    }

    void CheckEnemyKillCount(int currentUnlockedLevel)
    {

        int enemiesKilled = EnemyHealth.enemiesKilledCount;
        int requiredKills = PlayerPrefs.GetInt("Level" + currentUnlockedLevel + "Kills", -1);
        
        if (enemiesKilled >= requiredKills)
        {
            UnlockNextLevel(currentUnlockedLevel + 1);
        }
    }

    void UnlockNextLevel(int levelToUnlock)
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);

        if (levelToUnlock <= buttons.Length)
        {
            buttons[levelToUnlock - 1].interactable = true;
            PlayerPrefs.SetInt("UnlockedLevel", levelToUnlock);
            PlayerPrefs.Save();
            EnemyHealth.enemiesKilledCount = 0;
        }
    }
}



