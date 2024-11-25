using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepShowHTP : MonoBehaviour
{
    public GameObject CountDown;
    public GameObject targetObject1;
    public GameObject targetObject2;
    public GameObject targetObject3;
    public GameObject targetObject4;
    public bool isStart = false;



    void Start()
    {
        // Ensure all target objects are initially hidden
        if (targetObject1 != null) targetObject1.SetActive(false);
        if (targetObject2 != null) targetObject2.SetActive(false);
        if (targetObject3 != null) targetObject3.SetActive(false);

        // Ensure targetObject4 is active at the start
        if (targetObject4 != null) targetObject4.SetActive(true);

        // Ensure CountDown is hidden at the start
        if (CountDown != null) CountDown.SetActive(false);

    }

  
    IEnumerator ShowObjectsWithCountDownJotabal()
    {
        isStart = true;
        // Show the countdown
        if (CountDown != null) CountDown.SetActive(true);

        // Wait for 6 seconds
        yield return new WaitForSeconds(6f);

        // Hide the countdown
        if (CountDown != null) CountDown.SetActive(false);

        // Activate targetObject1, targetObject2, and targetObject3
        if (targetObject1 != null) targetObject1.SetActive(true);
        if (targetObject2 != null) targetObject2.SetActive(true);
        if (targetObject3 != null) targetObject3.SetActive(true);

        // Deactivate targetObject4
        if (targetObject4 != null) targetObject4.SetActive(false);
    }


    public void JotabalDanceSteps()
    {
        StartCoroutine(ShowObjectsWithCountDownJotabal());
      
    }

 
    public void StopDance(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(StopDanceAfterDelay());
        }
    }

    private IEnumerator StopDanceAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait for 2 seconds


        isStart = false;

        // Reset the state of objects
        if (CountDown != null) CountDown.SetActive(false);
        if (targetObject1 != null) targetObject1.SetActive(false);
        if (targetObject2 != null) targetObject2.SetActive(false);
        if (targetObject3 != null) targetObject3.SetActive(false);
        if (targetObject4 != null) targetObject4.SetActive(false);
    }
}
