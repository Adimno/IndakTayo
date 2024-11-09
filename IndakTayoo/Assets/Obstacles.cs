using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject Head;
    public GameObject Right;
    public GameObject Left;
    public AudioSource ObstacleSounds;
    public TotalPoints points;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Head)
        {
            Debug.Log("MALI");
            points.DecrementPoints(10);
            ObstacleSounds.Play();
        }
    }
}
