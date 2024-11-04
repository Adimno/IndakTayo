using System.Collections;
using TMPro;
using UnityEngine;

public class HTPViewMovementControl : MonoBehaviour
{
    public GameObject[] MovementCanvas;
    public TextMeshProUGUI textComponent;

    private bool[] hasBeenSeen; // Tracks if each canvas object has been seen

    private void Start()
    {
        // Initialize the hasBeenSeen array to match the number of objects in MovementCanvas
        hasBeenSeen = new bool[MovementCanvas.Length];
    }

    private void Update()
    {
        // Loop through each canvas and check if it's active
        for (int i = 0; i < MovementCanvas.Length; i++)
        {
            if (MovementCanvas[i].activeSelf && !hasBeenSeen[i])
            {
                // Mark the object as seen
                hasBeenSeen[i] = true;

                // Check if all objects have been seen
                if (AllObjectsSeen())
                {
                    MovementCanvasHTP();
                }
            }
        }
    }

    private bool AllObjectsSeen()
    {
        // Check if all objects have been set to true in hasBeenSeen
        foreach (bool seen in hasBeenSeen)
        {
            if (!seen)
            {
                return false;
            }
        }
        return true;
    }

    public void MovementCanvasHTP()
    {
        // Change text color to green if textComponent is not null
        if (textComponent != null)
        {
            textComponent.color = Color.green;
        }
    }
}
