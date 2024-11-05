using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandPercent : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Text field to display the percentage
    public TaskPercentage taskPercentage; // Reference to TaskPercentage component

    void Start()
    {
        // Check if taskPercentage is assigned in the Inspector
        if (taskPercentage == null)
        {
            // Try to find TaskPercentage on the same GameObject if not assigned
            taskPercentage = GetComponent<TaskPercentage>();

            // If TaskPercentage is on a different GameObject, assign it manually in the Inspector
            if (taskPercentage == null)
            {
                Debug.LogWarning("TaskPercentage component not found!");
            }
        }
    }

    void Update()
    {
        if (taskPercentage != null)
        {
            // Display the task percentage in the TextMeshPro field
            int currentPercentage = taskPercentage.TaskPercentageValue;
            textMeshPro.text = currentPercentage + "%";

            // Optional: Log the current percentage for debugging
            Debug.Log("HandPercent displaying task percentage: " + currentPercentage);
        }
    }
}
