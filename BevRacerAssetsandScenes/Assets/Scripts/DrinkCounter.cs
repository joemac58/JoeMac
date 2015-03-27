using UnityEngine;
using System.Collections;

public class DrinkCounter : MonoBehaviour {

	public bool isQuit = false;

	// Use this for initialization
	void Start () {
	
	}

	float counter = 100;
	float count;			//variable used to update the counter

	// Update is called once per frame
	void Update () {

		//If the player is drinking, then update the counter
		count = Input.GetAxis ("Vertical");
		if (count < 0) 
			counter-= 1;

		//Game Over Screen if nothing left to drink
		if (counter == 0) {
			GetComponent<GUIText>().text = "Congratulations you drank it all!/n Press escape to return to exit the game/nPress 1 to return to start menu";
			Time.timeScale = 0;
			if (Input.GetKey (KeyCode.Escape)) {
				Application.Quit();
			}
			if(Input.GetKey (KeyCode.Alpha1)){
				Application.LoadLevel("main_menu");
			}
		}
	}
}