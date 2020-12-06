using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreInit : MonoBehaviour
{
    public Text level1Text;
    public Text level2Text;
    void Start()
    {
        level1Text.text = PlayerPrefs.GetInt("Level1HS").ToString();
        level2Text.text = PlayerPrefs.GetInt("Level2HS").ToString();
    }

    public void resetHighScores()
    {
        level1Text.text = "0";
        level2Text.text = "0";
        
        PlayerPrefs.SetInt("Level1HS", 0);
        PlayerPrefs.SetInt("Level2HS", 0);
    }
}
