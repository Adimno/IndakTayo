using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HTPHideShowChecker : MonoBehaviour
{
    public GameObject MainCanvasParent;
    public GameObject MainChecklistParent;
    public GameObject QuitCanvas; 
    public TextMeshProUGUI textComponent1; // Linked to GamePlayCanvas
    public TextMeshProUGUI textComponent2; // Linked to MovementCanvas
    public TextMeshProUGUI textComponent3;

    private void Update()
    {

        // Check MovementCanvas independently
        if (MainCanvasParent != null && !MainCanvasParent.activeSelf && textComponent1.color != null)
        {
            textComponent1.color = Color.green;
        }

        // Check GamePlayCanvas independently
        if (MainChecklistParent != null && !MainChecklistParent.activeSelf && textComponent2.color != null)
        {
            textComponent2.color = Color.green;
        }

        // Check GamePlayCanvas independently
        if (QuitCanvas != null && QuitCanvas.activeSelf && textComponent3.color != null)
        {
            textComponent3.color = Color.green;
        }
    }
}
