using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsCanvas : MonoBehaviour
{
    public AttemptsValue attempts;

    public void TryAgain()
    {
        StartCoroutine(LoadScene("Jotabal_Dance"));
    }

    public void Next()
    {
        attempts.ResetAttempts();
        StartCoroutine(LoadScene("Jotabal_Dance"));
    }

    public void MoveToMain_Menu()
    {
        StartCoroutine(LoadScene("MainMenu"));
        attempts.ResetAttempts();
        
    }

    IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
