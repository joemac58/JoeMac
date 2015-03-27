using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	public bool isQuit = false;
	public bool isConvention = false;
	public bool isStreet = false;
	public bool isBar = false;
	
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
			Application.Quit ();
		}
		if(isConvention == true){
			//load level
			Application.LoadLevel("gamev21");
		}
		if (isStreet == true) {
			Application.LoadLevel ("level2");
		}
		if (isBar == true) {
			Application.LoadLevel("level3");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
