using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class proceedDanceHTP : MonoBehaviour
{
    public GameObject[] objectsToMonitor;
    public GameObject audioSource;
    public BoxCollider TurnOnCollider;
    void Update()
    {
        if (AllTextIsGreen())
        {
            audioSource.SetActive(true);


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
