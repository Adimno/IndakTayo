using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class SceneLoaderMainMenu : MonoBehaviour
{
 
    // This method is called when the button is clicked
    public void MoveToJotabal_Dance()
    {
  
            StartCoroutine(LoadScene("Jotabal_Dance"));
 
 

    }

    public void MoveToPolkabal_Dance()
    {
  
            StartCoroutine(LoadScene("Polkabal_Dance"));
   
    }


    public void MoveToMain_Menu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    public void MoveToHow_to_Play()
    {
        StartCoroutine(LoadScene("How_to_Play"));
    }


    public void QuitGame()
    {
        Application.Quit();
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
