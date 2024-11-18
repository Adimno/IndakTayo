using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressScript : MonoBehaviour
{
    public GameObject GrabDress;
    public GameObject AssetDress;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dress"))
        {
            GrabDress.SetActive(false);
            AssetDress.SetActive(true);
        }
    }
}
