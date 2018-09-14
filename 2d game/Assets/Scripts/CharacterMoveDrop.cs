using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveDrop : MonoBehaviour
{

    // Player Movement Variables
    public int MoveSpeed;
    public float JumpHeight;

    // Player grounded variables
    public Transform groundcheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    // Use this for initialization
    void Start()
    {

    }

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {

        // This code makes the character jump
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            Jump();
        }
        // This code makes the character Drop
        if (Input.GetKeyDown(KeyCode.S))
        {
            Drop();
        }

        // This code makes the character move from side to side using the A&D keys
        if (Input.GetKey(KeyCode.D)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if(Input.GetKey (KeyCode.A)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
    }
    public void Drop()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -JumpHeight);
    }
 
}

