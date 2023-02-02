using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    private Rigidbody2D rigidBody;
    private bool isJumping;
    public Animator anim;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        rigidBody.velocity = new Vector2(moveSpeed, rigidBody.velocity.y);

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            anim.SetBool("jumping",true);
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
