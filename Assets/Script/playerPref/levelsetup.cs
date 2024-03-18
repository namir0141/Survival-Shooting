using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelsetup : MonoBehaviour
{
    void Start()
    {
        SetRequiredKillsForLevels();
    }

    void SetRequiredKillsForLevels()
    {
        
        PlayerPrefs.SetInt("Level1Kills", 3);
        PlayerPrefs.SetInt("Level2Kills", 5);
        PlayerPrefs.SetInt("Level3Kills", 8);
        PlayerPrefs.SetInt("Level4Kills", 11);
        PlayerPrefs.SetInt("Level5Kills", 15);
        PlayerPrefs.SetInt("Level6Kills", 19);
        PlayerPrefs.SetInt("Level7Kills", 21);
        PlayerPrefs.SetInt("Level8Kills", 33);
        PlayerPrefs.SetInt("Level9Kills", 44);
        PlayerPrefs.SetInt("Level10Kills", 59);


        PlayerPrefs.Save(); 
    }
}
