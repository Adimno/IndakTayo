using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainingValue : MonoBehaviour
{
    public TextMeshProUGUI RemainingText; // Assign in Inspector
    public GameObject ButtonAttempts;
    public GameObject TextAttempts;

    void Update()
    {
        int attemptsToPass = PlayerPrefs.GetInt("attempts");
        int remaining = 3 - attemptsToPass;

        if (remaining < 0)
        {
            remaining = 0;
        }

        RemainingText.text = remaining.ToString();



        if (remaining == 0)
        {
            ButtonAttempts.SetActive(false);
            TextAttempts.SetActive(true);
        }
        else
        {
            ButtonAttempts.SetActive(true);
            TextAttempts.SetActive(false);
        }
    }

}
