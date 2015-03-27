using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {
	public float inputValue;
	// Update is called once per frame
	void Start () {
		GetComponent<AudioSource>().Play ();
}
}