using UnityEngine;
using System.Collections;

public class ChaserController : MonoBehaviour {


	public float zMove = 1;             // object's z movement: adjust in Inspector

	public bool slowDown = false;
	public bool slowDown2 = false;

	void Start(){
		// apply a base value to z velocity to
		// move towards or away from player
		GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, zMove);
		GetComponent<AudioSource>().Play ();
	}

	//Called from AnchorPointA script if the player is sprinting in Range A
	void SlowDown(){
		slowDown = true;	//Tell the slider to slow down
	}

	//Called from AnchorPointA script if the player is no longer sprinting in Range A
	void isNotSlowDown(){
		slowDown = false;	//Tell the slider it no longer needs to slow down
	}

	void SlowDown2(){
		slowDown2 = true;
	}

	void isNotSlowDown2(){
		slowDown2 = false;
	}

	void DefaultChaseSpeed(){
		zMove = 1f;
		GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, zMove);
		GetComponent<AudioSource>().Play ();
	}

	void FixedUpdate()
	{

		//use to determine if chaser moves forwards or backwards
		if (transform.position.z > -109f) {
			Application.LoadLevel("gameOverCaught");
		}

		//if player is sprinting, then we want the chaser to fall behind
		if(slowDown == true){
			zMove = -1f;
			GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, zMove);
			GetComponent<AudioSource>().Stop ();
		}

		if (slowDown == false) {
			DefaultChaseSpeed();
		}

		if (slowDown == true && slowDown2 == true) {
			zMove = -2f;
			GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, zMove);
		}

		if (slowDown2 == false && slowDown == true) {
			//SlowDown();
		}

		//set the range for the z position.
		GetComponent<Rigidbody>().position = new Vector3(GetComponent<Rigidbody>().position.x,GetComponent<Rigidbody>().position.y,Mathf.Clamp(GetComponent<Rigidbody>().position.z, -124.2469f, -108.7572f));


	}
}
