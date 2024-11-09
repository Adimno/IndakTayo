using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeadMovementLogic : MonoBehaviour
{
    public GameObject cameraHead;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI textComponent2;
    public TextMeshProUGUI textComponent3;
    public TextMeshProUGUI textComponent4;   
    public TextMeshProUGUI textComponent5;
    public TextMeshProUGUI textComponent6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the Euler angles from the rotation quaternion
        float xRotation = cameraHead.transform.rotation.eulerAngles.x;
        float yRotation = cameraHead.transform.rotation.eulerAngles.y;
        float zRotation = cameraHead.transform.rotation.eulerAngles.z;
        Debug.Log("x: " + xRotation + " y: " + yRotation + " z: " + zRotation);

        //PITCH
        // LOOK UP
        if (xRotation >= 300f && xRotation <= 320f)
        {
            if (textComponent != null)
            {
                textComponent2.color = Color.green;
            }
        }
        //PITCH
        // LOOK DOWN
        else if (xRotation >= 60f && xRotation <= 75f)
        {
            if (textComponent2 != null)
            {
                textComponent2.color = Color.green;
            }
        }

        //YAW
        //LOOK LEFT
        else if (yRotation >= 100f && yRotation <= 110f)
        {
            if (textComponent3 != null)
            {
                textComponent3.color = Color.green;
            }
        }
        //YAW
        //LOOK RIGHT
        else if (yRotation >= 250f && yRotation <= 260f)
        {
            if (textComponent4!= null)
            {
                textComponent4 .color = Color.green;
            }
        }

        //ROLL
        //TILT TO THE LEFT
        else if (zRotation >= 70f && zRotation <= 80f)
        {
            if (textComponent5 != null)
            {
                textComponent5.color = Color.green;
            }
        }
        //ROLL
        //TILT TO THE RIGHT
        else if (zRotation >= 270f && zRotation <= 300f)

            if (textComponent6 != null)
            {
                textComponent6.color = Color.green;
            }
    }
    
}
