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

		Application.LoadLevel ("ScoreBoard");
	}
	public void clickMenu() {

		Application.LoadLevel ("Menu");
	}

}
