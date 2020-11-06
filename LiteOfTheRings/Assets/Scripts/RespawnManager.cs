using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public List<Respawn> respawnableObjects;

    private void Awake()
    {
        respawnableObjects = new List<Respawn>();
    }

    public void reset()
    {
        foreach (Respawn respawn in this.respawnableObjects)
        {
            respawn.respawn();
        }
    }

    public void register(Respawn respawn)
    {
        this.respawnableObjects.Add(respawn);
    }
}
