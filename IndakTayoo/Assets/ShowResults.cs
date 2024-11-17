using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowResults : MonoBehaviour
{
    public GameObject MaleWall;
    public GameObject FemaleWall;
    public GameObject ResultsCanvas;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == MaleWall || other.gameObject == FemaleWall)
        {
            StartCoroutine(ShowResultsWithDelay());
        }
    }

    IEnumerator ShowResultsWithDelay()
    {
        yield return new WaitForSeconds(2f);  // Wait for 2 seconds
        ResultsCanvas.SetActive(true);         // Show the ResultsCanvas
    }
}
