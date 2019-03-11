using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseMenuController : MonoBehaviour
{
    public UISprite background;
    //public GameObject pause;
    public GameObject pauseMenu;
    
    public GameObject virtualBtnMenu;
    
    void Start()
    {
        Color c = background.color;
        c = new Color(c.r,c.g,c.b,c.a*0.6f);
        background.color = c;
        OnContinueBtns();
    }

    void OnPauseBtns(){
        pauseMenu.SetActive(true);
        virtualBtnMenu.SetActive(false);
        // Transform[] pauseTransform = pauseMenu.GetComponentsInChildren<Transform>();
        // Transform[] virtualTransform = virtualBtnMenu.GetComponentsInChildren<Transform>(); 
        // foreach (Transform child in pauseTransform){
        //     UISprite childSprite = child.gameObject.GetComponent<UISprite>();
        //     UILabel childLabel = child.gameObject.GetComponent<UILabel>();
        //     if (childSprite != null)
        //         childSprite.enabled = true;
        //     else if (childLabel != null)
        //         childLabel.enabled = true;
        // }
        
        // foreach (Transform child in virtualTransform){
        //     UISprite childSprite = child.gameObject.GetComponent<UISprite>();
        //      UILabel childLabel = child.gameObject.GetComponent<UILabel>();
        //     if (childSprite != null)
        //         childSprite.enabled = false;
        //     else if (childLabel != null)
        //         childLabel.enabled = false;
        // }
            
        // UISprite pauseSprite = pause.GetComponent<UISprite>();
        // pauseSprite.enabled = false;
    }
    void OnContinueBtns(){
        pauseMenu.SetActive(false);
        virtualBtnMenu.SetActive(true);
        // Transform[] pauseTransform = pauseMenu.GetComponentsInChildren<Transform>();
        // Transform[] virtualTransform = virtualBtnMenu.GetComponentsInChildren<Transform>(); 
        // foreach (Transform child in pauseTransform){
        //     UISprite childSprite = child.gameObject.GetComponent<UISprite>();
        //     UILabel childLabel = child.gameObject.GetComponent<UILabel>();
        //     if (childSprite != null)
        //         childSprite.enabled = false;
        //     else if (childLabel != null)
        //         childLabel.enabled = false;
        // }
        
        // foreach (Transform child in virtualTransform){
        //     UISprite childSprite = child.gameObject.GetComponent<UISprite>();
        //      UILabel childLabel = child.gameObject.GetComponent<UILabel>();
        //     if (childSprite != null)
        //         childSprite.enabled = true;
        //     else if (childLabel != null)
        //         childLabel.enabled = true;
        // }
        // UISprite pauseSprite = pause.GetComponent<UISprite>();
        // pauseSprite.enabled = true;
    }

    public void OnPause(){
        OnPauseBtns();
    }

    public void OnContinue(){
        OnContinueBtns();
    }
    

    public void OnRestart(){
        string missionName = PlayerPrefs.GetString("MissionName");
        if(missionName == null || missionName.Length == 0)
            SceneManager.LoadScene("start");
        SceneManager.LoadScene(missionName);
    }

    public void OnExit(){
        SceneManager.LoadScene("menu");
    }
}
