using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public GameObject SelectDifficultyCanvas;
    public GameObject CharacterSelectionCanvas;
    public SpeedController speedController;
    public GameObject MusicEasy;
    public GameObject MusicAverage;
    public GameObject MusicHard;
    public static float savedSpeed;

    // Getter for savedSpeed
    public static float GetSavedSpeed()
    {
        return savedSpeed;
    }

    public void Easy()
    {
        speedController.speed = 0.5f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicEasy.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Average()
    {
        speedController.speed = 1.0f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicAverage.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Hard()
    {
        speedController.speed = 1.5f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicHard.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }
}
