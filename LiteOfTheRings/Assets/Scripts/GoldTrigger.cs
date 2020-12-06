using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldTrigger : MonoBehaviour
{
    private AchievementManager acm;
    void Start()
    {
        acm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<AchievementManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>().playSound();
            acm.addScore(1);
            Destroy(gameObject);
        }
    }
}
