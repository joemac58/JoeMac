using UnityEngine;
using System.Collections;

public class CupSlider : MonoBehaviour {

	public GameObject target;

	public float inputValue;
	public float timeMultiplyer;
	public bool rangeA = false;
	public bool rangeB = false;

	// Use this for initialization
	void Start () {
	
	}

	void RangeA(){
		rangeA = true;
	}

	void isNotRangeA(){
		rangeA = false;
	}
	
	void RangeB(){
		rangeB = true;
	}

	void isNotRangeB(){
		rangeB = false;
	}
	
	// Update is called once per frame
	void Update () {
		inputValue = Input.GetAxis ("Vertical");

		if (transform.position.z < -41f) {
			Application.LoadLevel("winlv3");
		}

		//Tapping the drink button, faster than holding
		if(inputValue > -1f && inputValue < 0){
			timeMultiplyer = 0.0055f;
			transform.position = new Vector3(-214.8278f, 5.369055f, Mathf.Clamp(transform.position.z, -41.12675f, -37.3479f));	//Set range for cup meter
			transform.Translate(Vector3.back * timeMultiplyer);
		}

		//Holding down drink button, slower than tapping
		if(inputValue == -1f){
			timeMultiplyer = 0.00125f;
			transform.position = new Vector3(-214.8278f, 5.369055f, Mathf.Clamp(transform.position.z, -41.12675f, -37.3479f));	//Set range for cup meter
			transform.Translate(Vector3.back * timeMultiplyer);
			GetComponent<AudioSource>().Play();
		}

		//If the player is sprinting in Range A and trying to drink, call the spillA function
		if(rangeA == true && (inputValue >= -1f && inputValue < 0)) {
			target = GameObject.Find("SpillMeter");
			target.SendMessage("spillA");
		}

		//if the player is sprinting in Range B and trying to drink, call the spillB function
		if(rangeB == true && (inputValue >= -1f && inputValue < 0)) {
			target = GameObject.Find("SpillMeter");
			target.SendMessage("spillB");
		}


	}
}
