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
    public static string difficultyText;

    // Getter for savedSpeed
    public static float GetSavedSpeed()
    {
        return savedSpeed;
    }

    public static string GetDifficulty()
    {
        return difficultyText;
    }

    public void Easy()
    {
        difficultyText = "Easy";
        speedController.speed = 0.5f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicEasy.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Average()
    {
        difficultyText = "Average";
        speedController.speed = 1.0f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicAverage.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Hard()
    {
        difficultyText = "Hard";
        speedController.speed = 1.5f;
        savedSpeed = speedController.speed;
        CharacterSelectionCanvas.SetActive(true);
        MusicHard.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }
}
