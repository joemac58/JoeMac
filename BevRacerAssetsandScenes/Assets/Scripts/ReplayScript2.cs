﻿using UnityEngine;
using System.Collections;

public class ReplayScript2 : MonoBehaviour {

	public bool isQuit = false;
	public bool isNextLevel = false;
	
	void OnMouseEnter(){
		//change text color
		GetComponent<Renderer>().material.color = Color.yellow;
	}
	
	void OnMouseExit(){
		//change text color
		GetComponent<Renderer>().material.color = Color.white;
	}
	
	void OnMouseUp(){
		//is this quit
		if (isQuit == true) {
			//quit the game
			Application.LoadLevel("main_menu");
		}
		if(isNextLevel == true){
			Application.LoadLevel("level3");
		}else{
			//load level
			Application.LoadLevel("level2");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
