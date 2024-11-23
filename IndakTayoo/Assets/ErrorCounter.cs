using UnityEngine;

public class ErrorCounter : MonoBehaviour
{
    // Counter variable to keep track of errors
    public int counter { get; private set; }
    public GameObject ResultCanvas;
    public GameObject Steps;

    // Method to increment the counter
    public void Increment()
    {
        counter++;
        if (counter == 10)
        {
            ResultCanvas.SetActive(true);
            Steps.SetActive(false);
        }
    }

    // Method to reset the counter to 0
    public void Reset()
    {
        counter = 0;
    }
}
