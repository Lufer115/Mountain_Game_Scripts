
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


// Handles image/text-based cutscene slides and then loads another scene.
public class Cutscene : MonoBehaviour
{
    public Image backgroundImage;
    public Text textUI;

    public Sprite[] backgrounds;
    public string[] texts;

    public int index;
    public Button rightArrowButton;

    public string sceneName;

    public event Action CutsceneComplete;

    private void Start()
    {
        index = 0;
        UpdateBackgroundAndText();
    }

    public void ChangeBackground()
    {
        index++;

        if (index >= backgrounds.Length)
        {
            LoadNextScene();
            return;
        }

        UpdateBackgroundAndText();
    }

    private void UpdateBackgroundAndText()
    {
        if (backgroundImage != null &&
            backgrounds != null &&
            index >= 0 &&
            index < backgrounds.Length)
        {
            backgroundImage.sprite = backgrounds[index];
        }

        if (textUI != null &&
            texts != null &&
            index >= 0 &&
            index < texts.Length)
        {
            textUI.text = texts[index];
        }
    }

    private IEnumerator DisplayText(string text)
    {
        if (textUI != null)
        {
            textUI.text = "";

            foreach (char character in text)
            {
                textUI.text += character;
                yield return new WaitForSeconds(0.02f);
            }
        }
    }

    private void LoadNextScene()
    {
        CutsceneComplete?.Invoke();

        if (!string.IsNullOrEmpty(sceneName))
            StartCoroutine(DelaySceneLoad());
    }

    private IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
