using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageShow : MonoBehaviour
{
    public GameObject ConcertStage;
    public GameObject VillageStage;
    public GameObject BallroomStage;
    private SceneLoadStage stageValue;

    // Update is called once per frame
    void Update()
    {
        string stage = stageValue.GetStageValue();

        if(stage == "Concert"){
            ConcertStage.SetActive(true);
        } else if(stage == "Village"){
            VillageStage.SetActive(true);
        } else if(stage == "Ballroom"){
            BallroomStage.SetActive(true);
        }
    }
}
