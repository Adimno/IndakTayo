using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{

    public GameObject SelectDifficultyCanvas;
    public GameObject CharacterSelectionCanvas;
    public SpeedController speedController;

    public void Easy()
    {
        speedController.speed = 0.5f;
        CharacterSelectionCanvas.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Average()
    {
        speedController.speed = 1.0f;
        CharacterSelectionCanvas.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }

    public void Hard()
    {
        speedController.speed = 1.5f;
        CharacterSelectionCanvas.SetActive(true);
        SelectDifficultyCanvas.SetActive(false);
    }
}
