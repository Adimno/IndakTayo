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
    public AudioSource MusicEasy;
    public AudioSource MusicAverage;
    public AudioSource MusicHard;

    void Start()
    {
        if (statusText != null)
        {
            statusText.text = "Stop";
            StopMaterial.SetActive(true);
            GoMaterial.SetActive(false);
            Debug.Log("Initial Status: STOP");
        }

        if (MusicEasy == null)
        {
            MusicEasy = GetComponent<AudioSource>();
        }

        if (MusicAverage == null)
        {
            MusicAverage = GetComponent<AudioSource>();
        }

        if (MusicHard == null)
        {
            MusicHard = GetComponent<AudioSource>();
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
                MusicEasy.Pause();
                MusicAverage.Pause();
                MusicHard.Pause();
                Debug.Log("Status Changed: GO");
            }
            else
            {
                statusText.text = "Stop";
                StopMaterial.SetActive(true);
                GoMaterial.SetActive(false);
                MusicEasy.Play();
                MusicAverage.Play();
                MusicHard.Play();
                Debug.Log("Status Changed: STOP");
            }
        }

        canToggle = true;
    }
}
