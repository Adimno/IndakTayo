using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceProgress : MonoBehaviour
{
    public GameObject Head;
    public GameObject Right;
    public GameObject Left;
    public TaskPercentage percent;
    public StartDance gender;  // This seems unnecessary now if GetGender() is static

    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        // Ensure that we only process this once, and if the other object is one of the designated parts (Head, Right, Left)
        if (!hasCollided && (other.gameObject == Head || other.gameObject == Right || other.gameObject == Left))
        {
            Debug.Log("MALI");

            // Use 'StartDance.GetGender()' to call the static method
            if (StartDance.GetGender() == "Male")
            {
                percent.IncrementTaskPercentage(1.69f);
            }
            else if (StartDance.GetGender() == "Female")
            {
                percent.IncrementTaskPercentage(1);
            }

            hasCollided = true;
        }
    }
}
