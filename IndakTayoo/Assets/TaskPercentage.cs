using UnityEngine;
using TMPro;

public class TaskPercentage : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private int taskPercentage = 0;

    void Update()
    {
        // Update the TextMeshPro text with the taskPercentage value
        textMeshPro.text = taskPercentage + "%";
    }

    // Property to get the taskPercentage value as read-only
    public int TaskPercentageValue
    {
        get { return taskPercentage; }
    }

    // Function to increment taskPercentage by a specified value
    public void IncrementTaskPercentage(int incrementValue)
    {
        taskPercentage += incrementValue;
        if (taskPercentage >= 100)
        {
            taskPercentage = 100; // Cap taskPercentage at 100
        }
    }

    // Function to decrement taskPercentage by a specified value
    public void DecrementTaskPercentage(int decrementValue)
    {
        taskPercentage -= decrementValue;
        if (taskPercentage < 0)
        {
            taskPercentage = 0; // Ensure taskPercentage does not go below 0
        }
    }
}
