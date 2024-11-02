using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HTPViewMovementControl : MonoBehaviour
{
    public GameObject MovementCanvas;
    public BoxCollider ColliderDestroy;
    public TextMeshProUGUI textComponent;

    private void Start()
    {
        MovementCanvas.SetActive(false);
    }
    private void Update()
    {
        if (MovementCanvas.gameObject.activeSelf)
        {
            // If canvas becomes active and objects are not already enabled, turn on all objects
            MovementCanvasHTP();
        }
    }

    public void MovementCanvasHTP()
    {
        if (MovementCanvas != null)
        {
            // Check if MovementCanvas is active before destroying the collider
            if (MovementCanvas.activeSelf)
            {
                Destroy(ColliderDestroy);
                if (textComponent != null)
                {
                    textComponent.color = Color.green;
                }
            }
         
        }
    }
}