using UnityEngine;

public class ErrorCounter : MonoBehaviour
{
    public int counter { get; private set; }
    public GameObject ResultCanvas;
    public GameObject Steps;

    public void Increment()
    {
        counter++;
        if (counter == 10)
        {
            ResultCanvas.SetActive(true);
            Steps.SetActive(false);
        }
    }


    public void Reset()
    {
        counter = 0;
    }
}
