using UnityEngine;

public class GameMechanicsManager : MonoBehaviour
{
    public GameObject[] gameMechanicsCanvases;
    public GameObject SelectDifficultyCanvas;
    
    private int currentIndex = 0;

    public void ShowNextGameMechanicsCanvas()
    {
        if (currentIndex < gameMechanicsCanvases.Length - 1)
        {
            gameMechanicsCanvases[currentIndex].SetActive(false);
            currentIndex++;
            gameMechanicsCanvases[currentIndex].SetActive(true);
        }
        else
        {
            // If at the last canvas, go to another screen (e.g., difficulty selection)
            gameMechanicsCanvases[currentIndex].SetActive(false);
            SelectDifficultyCanvas.SetActive(true);
        }
    }

  //  public void ShowPreviousGameMechanicsCanvas() back button code
  //  {
   //     if (currentIndex > 0)
  //      {
//            gameMechanicsCanvases[currentIndex].SetActive(false);
///            currentIndex--;
  //          gameMechanicsCanvases[currentIndex].SetActive(true);
 //       }
 //       else
 //       {
            // If at the first screen, go back to welcome
   //         gameMechanicsCanvases[currentIndex].SetActive(false);
          
   //     }
//    }
}
