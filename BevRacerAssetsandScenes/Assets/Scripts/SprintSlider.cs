using UnityEngine;
using System.Collections;

public class SprintSlider : MonoBehaviour {

	public float inputValue;
	public float timeMultiplyer;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		inputValue = Input.GetAxis ("Vertical");

		//Sprint meter moves when tapped
		if ((inputValue < 0.55f) && (inputValue > 0f)) {
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, -174.4499f, -168.5f), 7.50834f, -9.689224f);	//Set range for sprint meter
			transform.Translate(Vector3.right * Time.deltaTime);	//move the meter if the player pushes the sprint button
		}

		//Sprint meter moves faster when input held down
		if (inputValue == 1) {
			timeMultiplyer = 0.025f;
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -174.4499f, -168.5f), 7.50834f, -9.689224f);	//Set range for sprint meter
			transform.Translate (Vector3.right * timeMultiplyer);
		}

		//Constantly setting speed back to base
		if (inputValue == 0) {
			timeMultiplyer = 0.025f;
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -174.4499f, -168.5f), 7.50834f, -9.689224f);	//Set range for sprint meter
			transform.Translate (Vector3.left * timeMultiplyer);
		}


	}
}
