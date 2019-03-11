using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChoose : MonoBehaviour
{
	public GameObject[] characters;
	private int characterIndex = 0;
	
	public void OnCharacterNext(){
		characterIndex++;
		characterIndex%=characters.Length;
		ChangeCharacter();
	}
	public void OnCharacterPre(){
		if(characterIndex==0)
			characterIndex=characters.Length-1;
		else
			characterIndex--;
		ChangeCharacter();
	}
	void ChangeCharacter(){
		//searching for a long time,missing my f**king visual studio
		foreach(GameObject character in characters)
			character.SetActive(false);
		characters[characterIndex].SetActive(true);
	}
}
