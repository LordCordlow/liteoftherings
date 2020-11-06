using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<RespawnManager>().register(this);
    }

    public virtual void respawn()
    {
        transform.position = originalPosition;
    }
}
