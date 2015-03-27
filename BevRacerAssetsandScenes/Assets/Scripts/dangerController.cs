using UnityEngine;
using System.Collections;

public class dangerController : MonoBehaviour
{
    public float zMove = -100;             // object's z movement: adjust in Inspector

    private float length;           // length of object
	
    // Use this for initialization
    void Start(){
        // fetch the object's length.  we'll use this to determine
        // if we've past our camera...
        length = GetComponent<Renderer>().bounds.size.z * 2;
	}

    // Fixed Update is our Physics update, use when moving rigidbodies...
    void FixedUpdate(){

        // apply a constant value to z velocity to
        // move towards or away from player
		GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, zMove);

		if (Input.GetKey (KeyCode.Equals)) {			//speed the player up
			zMove = -110;
			Camera.main.fieldOfView = 14f;
		}

		//slow the player down
		if(Input.GetKey (KeyCode.Minus)){
			zMove = -90;
			Camera.main.fieldOfView = 16f;
		}

        // if our object's length is past our camera, then...
        if (GetComponent<Rigidbody>().position.z < -length){
            // delete our object
            Destroy(gameObject);
        }
    }
}
