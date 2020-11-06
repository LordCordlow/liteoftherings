using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 1f;

    public static bool facingRight = true;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 oldVelocity = rigidbody.velocity;
        oldVelocity.x = speed * horizontal;
        rigidbody.velocity = oldVelocity;

        /*
        if((facingRight && horizontal < 0) || (!facingRight && horizontal > 0)) {
            flip();
        } */

        if(Input.GetButtonDown("Jump")) {
            rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if (facingRight && horizontal < 0)
        {
            flip();
        } else if (!facingRight && horizontal > 0)
        {
            flip();
        }
    }

    private void flip()
    {
        facingRight = !facingRight;

        Vector3 scale = this.transform.localScale;
        scale.x *= -1;
        this.transform.localScale = scale;
    }
}