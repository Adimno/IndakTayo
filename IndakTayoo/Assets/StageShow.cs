using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageShow : MonoBehaviour
{
    public GameObject ConcertStage;
    public GameObject VillageStage;
    public GameObject BallroomStage;

    // Update is called once per frame
    void Update()
    {
        string stage = PlayerPrefs.GetString("stage");

        if (stage == "Concert"){
            ConcertStage.SetActive(true);
        } else if(stage == "Village"){
            VillageStage.SetActive(true);
        } else if(stage == "Ballroom"){
            BallroomStage.SetActive(true);
        }
    }
}
