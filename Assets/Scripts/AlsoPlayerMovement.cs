using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlsoPlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpSpeed;
    private Rigidbody2D body;
    public bool isJumping;
    private Animator anim;

    private void Awake()
    {
        //Grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        body.freezeRotation = true;
        
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Flip player when moving
        if (horizontalInput > 0.01f)
            {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
            {
            transform.localScale = new Vector3(-1, 1, 0);
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == false)
            {
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
            anim.SetTrigger("Jump");
            isJumping = true;
        }

        //Set animator parameters
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("isjumping", isJumping);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
