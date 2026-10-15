// NOTE: This is a portfolio-oriented reconstruction from the compiled Unity WebGL build.
// It is not guaranteed to be byte-for-byte identical to the lost original source.

using UnityEngine;

// Rigidbody wall-climbing system reconstructed from the final build.
public class WallClimb : MonoBehaviour
{
    private Rigidbody rb;

    public float climbSpeed = 3f;
    public float stickToWallForce = 5f;
    public bool isInClimbZone;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isInClimbZone || rb == null)
            return;

        if (Input.GetKey(KeyCode.Space))
        {
            rb.useGravity = false;

            float vertical = Input.GetAxis("Vertical");

            rb.velocity = new Vector3(
                rb.velocity.x,
                vertical * climbSpeed,
                rb.velocity.z
            );
        }
        else
        {
            rb.useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
            isInClimbZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            isInClimbZone = false;

            if (rb != null)
                rb.useGravity = true;
        }
    }
}
