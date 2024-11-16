using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopWatch : MonoBehaviour
{
    public TextMeshProUGUI statusText;
    public GameObject Finger;
    private bool canToggle = true;
    public GameObject GoMaterial;
    public GameObject StopMaterial;

    void Start()
    {
        if (statusText != null)
        {
            statusText.text = "Stop";
            StopMaterial.SetActive(true);
            GoMaterial.SetActive(false);
            Debug.Log("Initial Status: STOP");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Finger && canToggle)
        {
            StartCoroutine(ToggleTextWithDelay());
        }
    }

    private IEnumerator ToggleTextWithDelay()
    {
        canToggle = false;
        yield return new WaitForSeconds(1);

        if (statusText != null)
        {
            if (statusText.text == "Stop")
            {
                statusText.text = "Go";
                GoMaterial.SetActive(true);
                StopMaterial.SetActive(false);
                Debug.Log("Status Changed: GO");
            }
            else
            {
                statusText.text = "Stop";
                StopMaterial.SetActive(true);
                GoMaterial.SetActive(false);
                Debug.Log("Status Changed: STOP");
            }
        }

        canToggle = true;
    }
}
