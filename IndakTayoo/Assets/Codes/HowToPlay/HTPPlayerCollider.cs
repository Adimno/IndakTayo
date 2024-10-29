using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Add this if using UnityEngine.UI text
using TMPro;           // Add this if using TextMeshPro

public class HTPPlayerCollider : MonoBehaviour
{
    public GameObject DestroyCollider;

    public TextMeshProUGUI textComponent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(DestroyCollider);

            // Change text color to green
            if (textComponent != null)
            {
                textComponent.color = Color.green;
            }
        }
    }
}