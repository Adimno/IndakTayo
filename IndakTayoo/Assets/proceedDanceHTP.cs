using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class proceedDanceHTP : MonoBehaviour
{
    public GameObject[] objectsToMonitor;
    public GameObject audioSource;

    void Update()
    {
        if (AllTextIsGreen())
        {
            audioSource.SetActive(true);
        }
    }

    bool AllTextIsGreen()
    {
        foreach (GameObject obj in objectsToMonitor)
        {
            TextMeshProUGUI textMesh = obj.GetComponent<TextMeshProUGUI>();
            if (textMesh == null || textMesh.color != Color.green)
            {
                return false;
            }
        }
        return true;
    }
}
