using UnityEngine;

// Rigidbody ladder-climbing controller reconstructed from the build metadata.
public class ClimbRB : MonoBehaviour
{
    public float climbSpeed = 3f;
    public bool isClimbing;
    public bool nearLadder;

    private Rigidbody rb;
    private float originalGravity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb != null)
            originalGravity = Physics.gravity.y;
    }

    private void Update()
    {
        if (!isClimbing || rb == null)
            return;

        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(
            rb.velocity.x,
            vertical * climbSpeed,
            rb.velocity.z
        );

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isClimbing = false;
            rb.useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            nearLadder = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            nearLadder = false;
            isClimbing = false;

            if (rb != null)
                rb.useGravity = true;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Kept as a hook because the compiled class contains this callback.
    }
}
