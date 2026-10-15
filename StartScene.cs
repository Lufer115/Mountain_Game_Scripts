

using UnityEngine;
using UnityEngine.SceneManagement;

// Simple scene-transition component reconstructed from the build.
public class StartScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Cutscene");
    }
}
