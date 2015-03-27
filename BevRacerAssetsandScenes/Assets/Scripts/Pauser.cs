using UnityEngine;
using System.Collections;

public class Pauser : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	bool pause = false;

		// Update is called once per frame
	void Update () {

		//Pauses game
		if(Input.GetButtonUp ("P")){
			if(!pause){
				Time.timeScale = 0;
				pause = true;
			}else{
				pause = false;
				Time.timeScale = 1;
			}
		}

	}
}
