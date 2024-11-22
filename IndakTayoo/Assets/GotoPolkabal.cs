using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GotoPolkabal : MonoBehaviour
{
    public string stageName;

    public void MoveToPolkabal_Dance()
    {
        PlayerPrefs.SetString("stage", stageName);
        PlayerPrefs.Save();
        StartCoroutine(LoadScene("Polkabal_Dance"));
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
