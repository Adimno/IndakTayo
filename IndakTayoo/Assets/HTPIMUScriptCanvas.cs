using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPIMUScriptCanvas : MonoBehaviour
{

    public GameObject CongratsCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ShowCongratsCanvasWithDelay());
        }
    }

    private IEnumerator ShowCongratsCanvasWithDelay()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        CongratsCanvas.SetActive(true); // Activate the canvas
    }
}
