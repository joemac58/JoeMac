using UnityEngine;
using System.Collections;

public class NewGameScript : MonoBehaviour {

	void Start(){

		Time.timeScale = 0;
		GetComponent<GUIText>().text = "Avoid obstacles and drink your drink! \nUse the a and d keys to move left and right \nUse the minus key to drink, But be careful, this will slow you down \nWhen your drink counter gets to zero, you win! \nPress Enter to start the game";

	}

	void Update(){

				if (Input.GetKey (KeyCode.Return)) {
						Time.timeScale = 1;
						GetComponent<GUIText>().text = "";
				}
		}
			

}
