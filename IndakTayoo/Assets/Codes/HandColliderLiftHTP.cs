using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HandColliderLiftHTP : MonoBehaviour
{
    public CapsuleCollider HandLeft;
    public CapsuleCollider HandRight;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI textComponent2;
    public BoxCollider Destroy;


    // Track whether each hand has triggered
    private bool isHandLeftTriggered = false;
    private bool isHandRightTriggered = false;

    public void OnTriggerEnter(Collider other)
    {
        // Check if the left hand triggered
        if (other == HandLeft && textComponent != null)
        {
            textComponent.color = Color.green;
            isHandLeftTriggered = true; // Mark left hand as triggered
        }

        // Check if the right hand triggered
        if (other == HandRight && textComponent2 != null)
        {
            textComponent2.color = Color.green;
            isHandRightTriggered = true; // Mark right hand as triggered
        }

        // Check if both hands have triggered, then destroy the collider
        if (isHandLeftTriggered && isHandRightTriggered)
        {
         
            Destroy(Destroy);
        }
    }
}
