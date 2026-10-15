
using UnityEngine;

// Handles the player's teleport/interact behavior.
public class PlayerInteraction : MonoBehaviour
{
    public Transform teleportTarget;
    public float interactionRange = 3f;
    public string interactableTag = "Interactable";
    public LayerMask ignoreLayerMask;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TryTeleport();
    }

    private void TryTeleport()
    {
        if (teleportTarget == null)
            return;

        float distance = Vector3.Distance(
            transform.position,
            teleportTarget.position
        );

        if (distance <= interactionRange)
            TeleportToTarget();
    }

    private void TeleportToTarget()
    {
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.position = teleportTarget.position;
        }
        else
        {
            transform.position = teleportTarget.position;
        }
    }
}
