using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDance : MonoBehaviour
{
    public GameObject Steps;
    public GameObject MaleSteps;
    public GameObject FemaleSteps;
    public StepsShow stepsShow;
    public GameObject CharacterSelection;

    // Start is called before the first frame update
    public void Male()
    {
        stepsShow.StartSequence();
        Steps.SetActive(true);
        MaleSteps.SetActive(true);
        FemaleSteps.SetActive(false);
        CharacterSelection.SetActive(false);

    }
    public void Female()
    {
        stepsShow.StartSequence();
        Steps.SetActive(true);
        MaleSteps.SetActive(false);
        FemaleSteps.SetActive(true);
        CharacterSelection.SetActive(false);
    }
}
