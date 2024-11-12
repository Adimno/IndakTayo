using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{

    public GameObject CharacterSelectionCanvas;
    public SpeedController speedController;

    public void Easy()
    {
        speedController.speed = 0.5f;
        CharacterSelectionCanvas.SetActive(true);
    }

    public void Average()
    {
        speedController.speed = 1.0f;
        CharacterSelectionCanvas.SetActive(true);
    }

    public void Hard()
    {
        speedController.speed = 1.5f;
        CharacterSelectionCanvas.SetActive(true);
    }
}
