using UnityEngine;
using System.Collections;

public class AnchorPointB : MonoBehaviour {

	public GameObject target;
	
	//calls the RangeA function on the CupSlider script
	void OnTriggerEnter (Collider collision){
		target = GameObject.Find ("CupMeterSlider");
		target.SendMessage ("RangeB");
	}
	
	void OnTriggerExit(Collider collision){
		target = GameObject.Find ("CupMeterSlider");
		target.SendMessage ("isNotRangeB");
	}
}

