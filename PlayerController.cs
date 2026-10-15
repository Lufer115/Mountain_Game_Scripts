

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintMultiplier = 1f;
    public float jumpHeight = 5f;

    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody rb;
    public GliderRB glidingScript;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (glidingScript != null)
            glidingScript.enabled = false;
    }

    private void Update()
    {
        MovePlayer();
        Jump();
    }

    private void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        float speed = moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
            speed *= sprintMultiplier;

        Vector3 velocity = movement * speed;

        rb.velocity = new Vector3(
            velocity.x,
            rb.velocity.y,
            velocity.z
        );
    }

    private void Jump()
    {
        isGrounded = Physics.CheckSphere(
            groundCheck.position,
            0.2f,
            groundLayer
        );

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            float jumpVelocity = Mathf.Sqrt(
                jumpHeight * -2f * Physics.gravity.y
            );

            rb.AddForce(
                Vector3.up * jumpVelocity,
                ForceMode.VelocityChange
            );
        }
    }
}
