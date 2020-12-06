using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public int life = 3;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            other.gameObject.SetActive(false);

            life--;
            if (life <= 0)
            {
                gameObject.SetActive(false);
                if (gameObject.CompareTag("Wraith"))
                {
                    GameObject.FindGameObjectWithTag("GameManager").GetComponent<AchievementManager>().addScore(5);
                }
                else
                {
                    GameObject.FindGameObjectWithTag("GameManager").GetComponent<AchievementManager>().addScore(2);
                }
            }
        }
    }
}
