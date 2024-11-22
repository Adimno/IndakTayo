using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHider : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject MainMenu;
    private SetMusic setMusicValue;


    // Getter for musicValue
    public string MusicValue
    {
        get { return setMusicValue.MusicValue; }
    }

    void Start()
    {
        StartCanvas.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerPrefs.SetString("music", setMusicValue.MusicValue);
            PlayerPrefs.Save();
            MainMenu.SetActive(false);
            StartCanvas.SetActive(true);
            Debug.Log("Player collide");
        }
    }

    public void HideCanvas()
    {
        if (StartCanvas != null)
        {
            PlayerPrefs.SetString("music", setMusicValue.MusicValue);
            PlayerPrefs.Save();
            MainMenu.SetActive(false);
            StartCanvas.SetActive(true);
        }
    }
}
