using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GotoJotabal : MonoBehaviour
{
    public string stageName;

    public void MoveToJotabal_Dance()
    {
        PlayerPrefs.SetString("stage", stageName);
        PlayerPrefs.Save();
        StartCoroutine(LoadScene("Jotabal_Dance"));
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
