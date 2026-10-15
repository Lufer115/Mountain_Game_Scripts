
using UnityEngine;

// Displays an interaction icon while the player is in range.
public class UIicon : MonoBehaviour
{
    public GameObject interactIcon;
    public bool isPlayerInRange;

    private void Update()
    {
        if (interactIcon != null)
            interactIcon.SetActive(isPlayerInRange);
    }

    public void ToggleInteraction()
    {
        isPlayerInRange = !isPlayerInRange;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            ToggleInteraction();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            ToggleInteraction();
        }
    }

    public void TeleportToTarget(Transform teleportPosition)
    {
        if (teleportPosition != null)
            transform.position = teleportPosition.position;
    }
}
