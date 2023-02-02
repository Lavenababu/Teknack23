using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigidBody.velocity = new Vector2(moveSpeed, rigidBody.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
        }
    }

    private bool IsGrounded()
    {
    //     Vector2 position = transform.position;
    //     Vector2 direction = Vector2.down;
    //     float distance = 0.5f;

    //     RaycastHit2D hit = Physics2D.BoxCast(position, new Vector2(0.5f, 0.5f), 0f, direction, distance, LayerMask.GetMask("Ground"));

    //     return hit.collider != null;
        return Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
    }
}
