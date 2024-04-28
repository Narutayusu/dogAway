using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float moveSpeed;
    public float jumpForce;
    public float highJumpForce;
    private bool isGrounded;
    private bool highjump;
    Vector2 move;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), 0f); 
        
        rb2d.velocity = new Vector2(move.x * moveSpeed, rb2d.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && highjump) 
        {
            rb2d.AddForce(Vector2.up * highJumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            highjump = false;
        }
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

        if (collision.gameObject.tag == "enemy")
        {
            GameManager.health -= 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "jump")
        {
            highjump = true;
            Destroy(other.gameObject);
        }
    }
}
