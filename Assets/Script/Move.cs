using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float moveSpeed;
    public float jumpForce;
    private bool isGrounded; // Flag to track ground contact
    Vector2 move;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), 0f); 
        
        rb2d.velocity = new Vector2(move.x * moveSpeed, rb2d.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false; 
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
