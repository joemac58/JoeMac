using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void isGameOver(){
		Debug.Log ("GameOver Screen should be up");
		Camera.current.depth = 2;
	}
}
