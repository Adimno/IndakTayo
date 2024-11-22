using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class SceneLoadStage : MonoBehaviour
{
    private string music;
    public string stageValue;

    void Update()
    {
        music = PlayerPrefs.GetString("music");

    }

    public void MoveToDance()
    {   
        if(music == "Polkabal"){
            PlayerPrefs.SetString("stage", stageValue);
            PlayerPrefs.Save();
            StartCoroutine(LoadScene("Polkabal_Dance"));

        } else if(music == "Joltabal"){
            PlayerPrefs.SetString("stage", stageValue);
            PlayerPrefs.Save();
            StartCoroutine(LoadScene("Jotabal_Dance"));
        }
  
   
    }

    public string GetStageValue()
    {
        return PlayerPrefs.GetString("music");
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
