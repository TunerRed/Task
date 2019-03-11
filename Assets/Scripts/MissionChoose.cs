using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionChoose : MonoBehaviour
{
    public UILabel missionLabel;
    private string missionName;

    void OnStart(){
        missionLabel = missionLabel.GetComponent<UILabel>();
    }

    public void OnMission(Collider mission){
        this.missionName = mission.gameObject.tag;
        missionLabel.text = missionName;
    }
}
