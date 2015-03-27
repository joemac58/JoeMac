using UnityEngine;
using System.Collections;

public class SpillMeterLv2 : MonoBehaviour {

	public float timeMultiplyer;
	public GameObject target;
	
	void spillA(){
		timeMultiplyer = .025f;
		transform.position = new Vector3 (2.944632f, 4.7201f, Mathf.Clamp (transform.position.z, -151.3536f, -116.4923f));
		transform.Translate (Vector3.forward * timeMultiplyer);
	}
	
	void spillB(){
		timeMultiplyer = .035f;
		transform.position = new Vector3 (2.944632f, 4.7201f, Mathf.Clamp (transform.position.z, -151.3536f, -116.4923f));
		transform.Translate (Vector3.forward * timeMultiplyer);
	}
	
	void isHit(){
		transform.position = new Vector3 (2.944632f, 4.7201f, Mathf.Clamp (transform.position.z, -151.3536f, -116.4923f));
		transform.Translate (Vector3.forward * 3);
	}
	
	void Update(){
		if (transform.position.z > -117f) {
			Application.LoadLevel("gameOverSpilt2");
		}
	}
	
}
