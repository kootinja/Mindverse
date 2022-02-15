using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float movementSpeed;
    public float jumpForce = 25f;
    public Rigidbody2D rb;
    //public Transform feet;
    //public LayerMask groundLayers;
    float mx;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");


        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = movement;
    }

    //public bool IsGrounded()
    //{
    //    //Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.5f, groundLayers);

    //    if(groundCheck != null)
    //    {
    //        return true;
    //    } else
    //    {
    //        return false;
    //    }
    //}

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = movement;
    }
}
