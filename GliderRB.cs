using UnityEngine;

// The build confirms fallSpeed, Rigidbody, StartGliding and StopGliding.
public class GliderRB : MonoBehaviour
{
    public float fallSpeed = 2f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        // The player controller initially keeps this component disabled.
    }

    private void Update()
    {
        if (!enabled || rb == null)
            return;

        // Reduce the player's downward velocity while gliding.
        if (rb.velocity.y < -fallSpeed)
        {
            rb.velocity = new Vector3(
                rb.velocity.x,
                -fallSpeed,
                rb.velocity.z
            );
        }
    }

    public void StartGliding()
    {
        enabled = true;

        if (rb == null)
            rb = GetComponent<Rigidbody>();

        if (rb != null && rb.velocity.y < 0f)
        {
            rb.velocity = new Vector3(
                rb.velocity.x,
                -fallSpeed,
                rb.velocity.z
            );
        }
    }

    public void StopGliding()
    {
        enabled = false;
    }
}
