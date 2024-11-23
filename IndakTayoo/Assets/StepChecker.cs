using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StepChecker : MonoBehaviour
{
    public bool[] boolArray = new bool[3] { false, false, false };
    public CheckUncheck checker;
    public TotalPoints points;
    public TaskPercentage percent;
    public AudioSource correct;
    public AudioSource wrong;
    public GameObject wrongDetector;
    public ErrorCounter counter;

    private bool hasTriggered = false; // Flag to ensure actions run only once

    void Update()
    {
        CheckAllTrue();
    }

    void CheckAllTrue()
    {
        // Check if all values in boolArray are true
        bool allTrue = true;
        foreach (bool value in boolArray)
        {
            if (!value)
            {
                allTrue = false;
                break;
            }
        }

        // If all values are true and hasTriggered is false, execute the actions
        if (allTrue && !hasTriggered)
        {
            Debug.Log("NICE");
            checker.SetCheckIconVisible(true);
            checker.SetUncheckIconVisible(false);
            points.IncrementPoints(10);
            percent.IncrementTaskPercentage(1);
            correct.Play();

            hasTriggered = true; // Set the flag to true to prevent future triggers
        } 


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == wrongDetector)
        {
            Debug.Log("banggaan");
            if (Array.Exists(boolArray, element => element == false))
            {
                wrong.Play();
                counter.Increment();
            }
            else
            {
                counter.Reset();
            }
        }

    }

    public void SetIndexTrue(int index)
    {
        if (index >= 0 && index < boolArray.Length)
        {
            boolArray[index] = true;
        }
    }
}
