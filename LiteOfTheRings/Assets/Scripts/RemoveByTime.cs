using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RemoveByTime : MonoBehaviour
{
    public float timeLimit = 2.0f;
    public float timeElapsed = 0.0f;

    private void OnEnable()
    {
        this.timeElapsed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.timeElapsed += Time.deltaTime;
        if (timeElapsed > timeLimit)
        {
            this.gameObject.SetActive(false);
        }
    }
}
