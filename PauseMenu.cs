using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject settingsMenuUI;
    public GameObject playerObject;
    public PlayerController playerControllerScript;
    public CameraController cameraControllerScript;

    public bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);

        Time.timeScale = 1f;
        EnablePlayerScripts();
        isPaused = false;
    }

    public void Pause()
    {
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(true);

        Time.timeScale = 0f;
        DisablePlayerScripts();
        isPaused = true;
    }

    public void OpenSettings()
    {
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);

        if (settingsMenuUI != null)
            settingsMenuUI.SetActive(true);
    }

    public void BackFromSettings()
    {
        if (settingsMenuUI != null)
            settingsMenuUI.SetActive(false);

        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(true);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

    private void DisablePlayerScripts()
    {
        if (playerControllerScript != null)
            playerControllerScript.enabled = false;

        if (cameraControllerScript != null)
            cameraControllerScript.enabled = false;
    }

    private void EnablePlayerScripts()
    {
        if (playerControllerScript != null)
            playerControllerScript.enabled = true;

        if (cameraControllerScript != null)
            cameraControllerScript.enabled = true;
    }
}
