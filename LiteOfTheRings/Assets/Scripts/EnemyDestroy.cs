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

            this.life--;
            if (this.life <= 0)
            {
                this.gameObject.SetActive(false);
                GameObject.FindGameObjectWithTag("GameManager").GetComponent<AchievementManager>().addScore(2);
            }
        }
    }
}
