using UnityEngine;
using System.Collections;

public class DrinkMeter : MonoBehaviour {

	public float inputValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		inputValue = Input.GetAxis ("Vertical");
		
		if ((inputValue > -0.75f) && (inputValue < 0f)) {
			transform.Translate(Vector3.down * Time.deltaTime);	//move the meter if the player pushes the drink button
		}
	}
}
