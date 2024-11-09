using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorTaskMonitor : MonoBehaviour
{

    public GameObject[] objectsToMonitor;
    public BoxCollider TurnOnCollider;
    void Update()
    {
        if (AllTextIsGreen())
        {

            TurnOnCollider.enabled = true;
        }
    }

    bool AllTextIsGreen()
    {
        foreach (GameObject obj in objectsToMonitor)
        {
            TextMeshProUGUI textMesh = obj.GetComponent<TextMeshProUGUI>();
            if (textMesh == null || textMesh.color != Color.green)
            {
                TurnOnCollider.enabled = false;
                return false;
            }
        }
        return true;
    }
}
