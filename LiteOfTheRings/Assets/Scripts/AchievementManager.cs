using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    void Start()
    {
        score = 0;
    }

    public void addScore(int earn)
    {
        if (earn == 1 && PlayerPrefs.GetInt("FirstGold") == 0)
        {
            PlayerPrefs.SetInt("FirstGold", 1);
            Debug.Log("Earned First Gold Achievement");
        }
        
        if (earn == 2 && PlayerPrefs.GetInt("OrcSlayer") == 0)
        {
            PlayerPrefs.SetInt("OrcSlayer", 1);
            Debug.Log("Earned Orc Slayer Achievement");
        }
        score += earn;
        scoreText.text = "Score: " + score;
    }
}
