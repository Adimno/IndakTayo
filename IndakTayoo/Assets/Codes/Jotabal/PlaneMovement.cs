using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float speed = 1.0f; // Speed of movement along the x-axis

    void Update()
    {
        // Move the object along the x-axis at the specified speed
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
