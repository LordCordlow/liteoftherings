using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDustCloud : MonoBehaviour
{
    [SerializeField]
    public GameObject dustCloud;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
        }
    }
}
