using UnityEngine;
using System.Collections;

public class BurnEffect : MonoBehaviour {

	public GameObject target;
	public Renderer rend;
	public float inputValue;
	//public float aplha = 0;


	void Start(){
		//rend = GetComponent<Renderer>();
		//rend.material.color.a = .1f;
		//ChangeAlpha ();
	}

	void ChangeAlpha(){
		//float i;
		//for(i=0; i>0; i++){
			//alph

	}
	
	// Update is called once per frame
	void Update () {
		if (inputValue < 0) {

			//rend.material.color.a += 0.5;
	}
}
}
