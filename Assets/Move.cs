using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
private Rigidbody2D rb2d;
    float moveSpeed,torque;

    Vector2 move;
 
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moveSpeed = 900f;
    }


    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        
    }

    private void FixedUpdate()
    {
        rb2d.AddForce(move*moveSpeed*Time.deltaTime);
        //rb2d.MovePosition(rb2d.position+(move*moveSpeed*Time.deltaTime));
    }
   
}
