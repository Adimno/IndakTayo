using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressScript : MonoBehaviour
{
    public GameObject GrabDress;
    public GameObject AssetDress;

    private Vector3 originalPosition; // Store the original position of the dress.

    void Start()
    {
        // Save the initial position of the dress.
        originalPosition = GrabDress.transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GrabDress)
        {
            GrabDress.SetActive(false);
            AssetDress.SetActive(true);

            // Reset GrabDress's position to the original position.
            GrabDress.transform.position = originalPosition;
        }
    }
}
