using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChecklistHTP : MonoBehaviour
{
    public GameObject IMUChecklist;
    public GameObject DestroyChecklist;
    public GameObject ChecklistCanvasIMU;
    public GameObject DestroyCollider;
    public GameObject GoRoomCanvasIMU;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IMUChecklist.SetActive(true);
            
            ChecklistCanvasIMU.SetActive(true);

            if(DestroyChecklist !=null)
            {
                DestroyChecklist.SetActive(false);
            }
        }

        GoRoomCanvasIMU.SetActive(false);
        Destroy(DestroyCollider);
    }
}
