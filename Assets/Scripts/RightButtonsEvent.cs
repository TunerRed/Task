using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButtonsEvent : MonoBehaviour
{
	public Transform player;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag("player").transform;
	}

	// Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnUp()
    {
	    player.position += player.forward * 10;
    }
    public void OnDown(){
	    player.position -= player.forward * 10;
    }
    public void OnLeft(){
    }
    public void OnRight(){
    }
    
}
