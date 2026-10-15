
using UnityEngine;

public class GliderDeactivation : MonoBehaviour
{
    public GameObject playerObject;
    public GliderRB gliderScript;

    private void OnTriggerEnter(Collider other)
    {
        if (playerObject != null && other.gameObject == playerObject)
        {
            if (gliderScript != null)
                gliderScript.StopGliding();
            else
            {
                GliderRB glider = other.GetComponent<GliderRB>();
                if (glider != null)
                    glider.StopGliding();
            }
        }
    }
}
