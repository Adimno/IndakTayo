using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsShow : MonoBehaviour
{
    public GameObject targetObject1;
    public GameObject targetObject2;
    public GameObject targetObject3;
    public GameObject targetObject4;

    void Start()
    {
        // Ensure targetObject1, targetObject2, and targetObject3 are hidden at the start
        if (targetObject1 != null)
            targetObject1.SetActive(false);

        if (targetObject2 != null)
            targetObject2.SetActive(false);

        if (targetObject3 != null)
            targetObject3.SetActive(false);

        // Ensure targetObject4 is active at the start
        if (targetObject4 != null)
            targetObject4.SetActive(true);

        StartCoroutine(HandleObjectsAfterDelay(6f));
    }

    IEnumerator HandleObjectsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Set targetObject1, targetObject2, and targetObject3 to active
        if (targetObject1 != null)
            targetObject1.SetActive(true);

        if (targetObject2 != null)
            targetObject2.SetActive(true);

        if (targetObject3 != null)
            targetObject3.SetActive(true);

        // Set targetObject4 to inactive
        if (targetObject4 != null)
            targetObject4.SetActive(false);
    }
}
