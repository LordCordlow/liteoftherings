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

        if (earn == 5 && PlayerPrefs.GetInt("WraithSlayer") == 0)
        {
            PlayerPrefs.SetInt("WraithSlayer", 1);
        }
        score += earn;
        scoreText.text = "Score: " + score;
    }

    public void resetScore()
    {
        score = 0;
        scoreText.text = "Score: 0";
    }

    public void setLevel1HighScore()
    {
        if (score > PlayerPrefs.GetInt("Level1HS"))
        {
            PlayerPrefs.SetInt("Level1HS", score);
        }
    }

    public void setLevel2HighScore()
    {
        if (score > PlayerPrefs.GetInt("Level2HS"))
        {
            PlayerPrefs.SetInt("Level2HS", score);
        }
    }
}
