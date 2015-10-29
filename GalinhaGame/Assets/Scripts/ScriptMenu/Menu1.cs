using UnityEngine;
using System.Collections;

public class Menu1 : MonoBehaviour {
	

	public void clickPlay() {
		Application.LoadLevel (1);
	}
	public void clickSair() {
		Application.Quit ();
	}
	public void ClickScore() {
		//Implementar scoreboard
		Debug.Log ("Pontos!");
	}
}
