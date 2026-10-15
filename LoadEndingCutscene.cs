
using UnityEngine;
using UnityEngine.SceneManagement;

// Loads the ending/cutscene scene after the player enters an interaction area.
public class LoadEndingCutscene : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject interactUI;
    public bool playerInRange;

    private void Start()
    {
        if (interactUI != null)
            interactUI.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
            LoadNextScene();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        playerInRange = true;

        if (interactUI != null)
            interactUI.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        playerInRange = false;

        if (interactUI != null)
            interactUI.SetActive(false);
    }

    private void LoadNextScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToLoad);
    }
}
