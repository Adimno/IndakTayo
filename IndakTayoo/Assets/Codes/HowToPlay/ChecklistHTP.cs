using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistHTP : MonoBehaviour
{
    public GameObject IMUChecklist;
    public GameObject DestroyChecklist;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IMUChecklist.SetActive(true);
            Destroy(DestroyChecklist);
            
        }
    }
}
