using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public GameObject GameMechanicsCanvas;
    public GameObject CharacterSelectionCanvas;

    void Start()
    {
        ShowWelcomeCanvas();
        StartCoroutine(SwitchCanvasesWithDelay());
    }

    private void ShowWelcomeCanvas()
    {
        WelcomeCanvas.SetActive(true);
        GameMechanicsCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowGameMechanicsCanvas()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas.SetActive(true);
        CharacterSelectionCanvas.SetActive(false);
    }

    public void ShowCharacterSelectionCanvas()
    {
        WelcomeCanvas.SetActive(false);
        GameMechanicsCanvas.SetActive(false);
        CharacterSelectionCanvas.SetActive(true);
    }

    private IEnumerator SwitchCanvasesWithDelay()
    {
        // Wait for 10 seconds, then show GameMechanicsCanvas
        yield return new WaitForSeconds(19f);
        ShowGameMechanicsCanvas();

        // Wait another 10 seconds, then show CharacterSelectionCanvas
        yield return new WaitForSeconds(30f);
        ShowCharacterSelectionCanvas();
    }
}
