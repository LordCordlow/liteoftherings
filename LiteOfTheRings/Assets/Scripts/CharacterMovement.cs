using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 5f;
    public bool jump = false;

    public static bool facingRight = true;

    private Rigidbody2D rigidbody;
    public Animator animator;

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

        animator.SetFloat("speed", Mathf.Abs(speed * horizontal));
        
        if((facingRight && horizontal < 0) || (!facingRight && horizontal > 0)) {
            flip();
        }
        
        if(Input.GetButtonDown("Jump") && !jump)
        {
            jump = true;
            rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            animator.SetBool("isJumping", true);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<RespawnManager>().reset();
        } else if (other.gameObject.CompareTag("Ground"))
        {
            jump = false;
            this.animator.SetBool("isJumping", false);
        } else if (other.gameObject.CompareTag("Ladder"))
        {
            Debug.Log("collision");
            climbLadder();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ladder"))
        {
            // Debug.Log("belepett");
            climbLadder();
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        climbLadder();
    }

    private void flip()
    {
        facingRight = !facingRight;

        Vector3 scale = this.transform.localScale;
        scale.x *= -1;
        this.transform.localScale = scale;
    }

    private void climbLadder()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("asd");
            rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}