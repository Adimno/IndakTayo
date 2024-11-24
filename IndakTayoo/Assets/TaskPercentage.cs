using UnityEngine;
using TMPro;

public class TaskPercentage : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private int taskPercentage = 0;

    void Update()
    {
        textMeshPro.text = taskPercentage + "%";
    }

    public int TaskPercentageValue
    {
        get { return taskPercentage; }
    }

    public void IncrementTaskPercentage(int incrementValue)
    {
        taskPercentage += incrementValue;
        if (taskPercentage >= 100)
        {
            taskPercentage = 100; 
        }
    }


}
