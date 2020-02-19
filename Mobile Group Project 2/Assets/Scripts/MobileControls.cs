using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControls : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;

    private bool facingRight = true;

    public bool grounded;

    public int extraJumps;
    public int extraJumpsValue;

    public bool jumpButtonDown;

    //public Joystick joystick;

    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (grounded == true)
        {
            extraJumps = 0;
        }
    }
    public void Jump()
    {
        if (extraJumps < extraJumpsValue && grounded == false)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps++;
        }
        else if (grounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    //These trigger events are to check if the player object is grounded 
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0 && !collision.isTrigger)
        {
            grounded = true;
            extraJumps = 0;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0 && !collision.isTrigger)
        {
            grounded = true;
            extraJumps = 0;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0 && !collision.isTrigger)
        {
            grounded = false;
            //jumpCount = 0;
        }
    }
}
