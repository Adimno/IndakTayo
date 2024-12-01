using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Add this if using UnityEngine.UI text
using TMPro;           // Add this if using TextMeshPro

public class HTPPlayerCollider : MonoBehaviour
{
    public GameObject DestroyCollider;

    public TextMeshProUGUI textComponent;
    public GameObject DanceSteps;
    public StepShowHTP Dance;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Dance.StartDance(other);
            DanceSteps.SetActive(true);

            Destroy(DestroyCollider);

            // Change text color to green
            if (textComponent != null)
            {
                textComponent.color = Color.green;
            }

        }
    }
}