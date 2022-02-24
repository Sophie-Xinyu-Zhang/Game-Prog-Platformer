using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCode : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
    int speed = 10;
    int jumpForce = 600;
    public LayerMask groundLayer;
    public Transform Feet;

    bool grounded = false;
    float groundCheckDis = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(Feet.position, groundCheckDis, groundLayer);
        anim.SetBool("Grounded", grounded);
    }

    // Update is called once per frame
    void Update()
    {
        // moving the player left and right
        float xSpeed = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
        anim.SetFloat("RightSpeed", xSpeed);
        anim.SetFloat("LeftSpeed", -xSpeed);
        

        if(grounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }
}
