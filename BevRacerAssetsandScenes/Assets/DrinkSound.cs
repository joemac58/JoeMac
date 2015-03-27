using UnityEngine;
using System.Collections;

public class DrinkSound : MonoBehaviour {

	public float inputValue;
	public AudioClip drinking;
	// Use this for initialization
	void Start () {
		//audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		inputValue = Input.GetAxis ("Vertical");
		if(inputValue < 0){
			transform.rotation = Quaternion.AngleAxis(45, Vector3.left);
			drinking = GetComponent<AudioSource>().clip;
			GetComponent<AudioSource>().Play ();
			//transform.rotation = Quaternion.AngleAxis(45, Vector3.left);
			//audio.Play ();

			//if(inputValue == 0){
				//transform.rotation = Quaternion.AngleAxis(45, Vector3.right);
				//audio.Stop ();
			}
		}

		//if(inputValue == 0){
		//	transform.rotation = Quaternion.AngleAxis(45, Vector3.right);
		//	audio.Stop ();
		//}

}
