using UnityEngine;
using System.Collections;

public class AnchorPointA : MonoBehaviour {

	public GameObject target;

	//calls the RangeA function on the CupSlider script
	void OnTriggerEnter (Collider collision){

		//Let the Drink Meter know that the player is sprinting in Range A
		//We are letting the CupSlider script know that if the player takes a drink, 
		//they need to send call the spill function in the SpillMeter script
		target = GameObject.Find ("CupMeterSlider");
		target.SendMessage ("RangeA");

		//Because the player is sprinting in Range A they outrun the ChaserSlider
		//We are letting the ChaserSlider know that if the player is sprinting in Range A
		//the ChaserSlider script needs to tell the object to slow down
		target = GameObject.Find ("ChaserSlider");
		target.SendMessage ("SlowDown");

	}

	void OnTriggerExit(Collider collision){
		//Let the Drink Meter know that the player is no longer sprinting in range A
		target = GameObject.Find ("CupMeterSlider");
		target.SendMessage ("isNotRangeA");

		//Letting the ChaserSlider know that the player is no longer sprinting in range A, thus 
		//the slider can speed back up (this is dependent on if AnchorPointB is referencing the slider also
		target = GameObject.Find ("ChaserSlider");
		target.SendMessage ("isNotSlowDown");
	}
}
