// NOTE: This is a portfolio-oriented reconstruction from the compiled Unity WebGL build.
// It is not guaranteed to be byte-for-byte identical to the lost original source.

using UnityEngine;

// Basic Rigidbody movement script found in the build.
public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movement = new Vector3(
            Input.GetAxis("Horizontal"),
            0f,
            Input.GetAxis("Vertical")
        );
    }

    private void FixedUpdate()
    {
        if (rb != null)
            rb.MovePosition(
                rb.position + movement * moveSpeed * Time.fixedDeltaTime
            );
    }
}
