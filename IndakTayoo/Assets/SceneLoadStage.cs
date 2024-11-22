using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneLoadStage : MonoBehaviour
{
    private string music;
    public string stageValue;

    // Reference to MainMenuHider
    public MainMenuHider mainMenuHider;

    void Update()
    {
        stageValue= PlayerPrefs.GetString("music");
        if (mainMenuHider != null)
        {
            music = mainMenuHider.MusicValue; // Access the getter
        }
        else
        {
            music = PlayerPrefs.GetString("music"); // Fallback
        }
    }

    public void MoveToDance()
    {
        if (music == "Polkabal")
        {
            PlayerPrefs.SetString("stage", stageValue);
            PlayerPrefs.Save();
            StartCoroutine(LoadScene("Polkabal_Dance"));
        }
        else if (music == "Joltabal")
        {
            PlayerPrefs.SetString("stage", stageValue);
            PlayerPrefs.Save();
            StartCoroutine(LoadScene("Jotabal_Dance"));
        }
    }

    public string GetStageValue()
    {
        return stageValue;
    }

    IEnumerator LoadScene(string sceneName)
    {
        // Load the scene asynchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait for the scene to finish loading
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
