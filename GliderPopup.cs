using UnityEngine;

// Shows a popup, pauses the game, and resumes after the player presses OK.
public class GliderPopup : MonoBehaviour
{
    public GameObject popupUI;
    public GameObject playerObject;
    public bool hasTriggered;

    private void Start()
    {
        if (popupUI != null)
            popupUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasTriggered)
            return;

        if (playerObject != null && other.gameObject != playerObject)
            return;

        hasTriggered = true;

        if (popupUI != null)
            popupUI.SetActive(true);

        Time.timeScale = 0f;
    }

    public void OnOkButtonPressed()
    {
        if (popupUI != null)
            popupUI.SetActive(false);

        Time.timeScale = 1f;
    }
}
