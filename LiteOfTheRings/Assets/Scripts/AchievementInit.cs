using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AchievementInit : MonoBehaviour
{
    public Image firstGoldImg;
    public Image orcSlayerImg;
    public Image completedImg;
    public Sprite unlockedSprite;
    public Sprite lockedSprite;
    void Start()
    {
        if (PlayerPrefs.GetInt("OrcSlayer") > 0)
        {
            orcSlayerImg.sprite = unlockedSprite;
        }

        if (PlayerPrefs.GetInt("Completed") > 0)
        {
            completedImg.sprite = unlockedSprite;
        }

        if (PlayerPrefs.GetInt("FirstGold") > 0)
        {
            firstGoldImg.sprite = unlockedSprite;
        }
    }

    public void resetAchievements()
    {
        firstGoldImg.sprite = lockedSprite;
        orcSlayerImg.sprite = lockedSprite;
        completedImg.sprite = lockedSprite;
        
        PlayerPrefs.SetInt("FirstGold", 0);
        PlayerPrefs.SetInt("OrcSlayer", 0);
        PlayerPrefs.SetInt("Completed", 0);
    }
}
