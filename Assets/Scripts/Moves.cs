using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Moves : MonoBehaviour
{
    public float speed = 15f;
    public float jump = 15f;
    private Rigidbody2D rb;
    public int maxJumps = 2;
    private int jumpsRemaining = 0;
    public Animator animator;
    private bool isFacingRight = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpsRemaining = maxJumps;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("RunSpeed", Mathf.Abs(horizontal));
        
        // Move player horizontally

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            animator.SetBool("Jump", true);
            // Jump by changing the y velocity
            rb.velocity = new Vector2(rb.velocity.x, jump);
            jumpsRemaining--;
        }
        // Flip player horizontally if moving left
        if (horizontal > 0 && !isFacingRight)
        {
            Flip();
        }
        // Flip player horizontally if moving right
        else if (horizontal < 0 && isFacingRight)
        {
            Flip();
        }

    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Ground"))
        {
            jumpsRemaining = maxJumps;
            animator.SetBool("Jump", false);
        }
        if (other.gameObject.tag == "Finish")
        {
            CameraFollow.Instance.scenetomoveto();
        }


    }


}
