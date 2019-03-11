using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
	
	public GameObject menu,start,info,setting,missionLabel;
	public float distance = 0.0f;
	
    public void OnStart(){
		menu.GetComponent<Animation>().Play("menuLeft");
		start.GetComponent<Animation>().Play("startDown");
	}
	public void OnPractice(){
		
	}
	public void OnSetting(){
		menu.GetComponent<Animation>().Play("menuLeft");
		setting.GetComponent<Animation>().Play("settingLeft");
	}
	public void OnInfo(){
		menu.GetComponent<Animation>().Play("menuLeft");
		info.GetComponent<Animation>().Play("infoUp");
	}
	public void OnQuit(){
		Application.Quit();
	}
	public void OnPlay(){
		string missionName = missionLabel.GetComponent<UILabel>().text;
		PlayerPrefs.SetString("MissionName",missionName);
		SceneManager.LoadScene(missionName);
	}
	public void OnBack(){
		start.GetComponent<Animation>().Play("startUp");
		menu.GetComponent<Animation>().Play("menuRight");
	}
	
	public void OnInfoBack(){
		info.GetComponent<Animation>().Play("infoDown");
		menu.GetComponent<Animation>().Play("menuRight");
	}
	
	public void OnSettingBack(){
		setting.GetComponent<Animation>().Play("settingRight");
		menu.GetComponent<Animation>().Play("menuRight");
	}
}
