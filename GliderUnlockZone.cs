using UnityEngine;

// This trigger enables the player's glider when the player reaches the unlock area.
public class GliderUnlockZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GliderRB glider = other.GetComponent<GliderRB>();

        if (glider != null)
            glider.enabled = true;
    }
}
