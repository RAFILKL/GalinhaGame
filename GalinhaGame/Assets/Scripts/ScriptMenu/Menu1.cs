using UnityEngine;
using System.Collections;

public class Menu1 : MonoBehaviour {
	

	public void clickPlay() {
        Application.LoadLevel("GamePlay");
    }
	public void clickSair() {
		Application.Quit ();
	}
	public void ClickScore() {
		//Implementar scoreboard
		Application.LoadLevel ("ScoreBoard");
	}
	public void clickMenu() {
		//Implementar scoreboard
		Application.LoadLevel ("Menu");
	}
}
