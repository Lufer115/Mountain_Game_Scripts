
using UnityEngine;

// Respawns the player at a designated checkpoint when entering the trigger.
public class RespawnBack : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (respawnPoint != null)
        {
            other.transform.position = respawnPoint.position;
            other.transform.rotation = respawnPoint.rotation;
        }
    }
}
