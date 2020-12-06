using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinMovement : MonoBehaviour
{
    public Transform dest1;
    public Transform dest2;
    private Rigidbody2D rigidbody;
    private bool facingRight = true;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (facingRight)
        {
            if (transform.position.x <= dest2.position.x)
            {
                Vector2 oldVelocity = rigidbody.velocity;
                oldVelocity.x = 6f * 1;
                rigidbody.velocity = oldVelocity;
            }
            else
            {
                flip();
            }
        }
        else
        {
            if (transform.position.x >= dest1.position.x)
            {
                Vector2 oldVelocity = rigidbody.velocity;
                oldVelocity.x = 6f * -1;
                rigidbody.velocity = oldVelocity;
            }
            else
            {
                flip();
            }
        }
    }

    private void flip()
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
