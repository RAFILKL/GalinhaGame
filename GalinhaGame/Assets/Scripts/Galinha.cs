using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour {
	public GameObject galinha;
	GameObject scg;
	SoundController sc;
	GameController gc;


	// Use this for initialization
	void Start () {
		scg = GameObject.FindGameObjectWithTag ("SoundController");
		sc = scg.GetComponent<SoundController> ();
		gc = gameObject.GetComponent<GameController> ();
	}

	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision hit) {
		if(hit.gameObject.tag == "Carro") {
			sc.chamaSom();
			Destroy (this.gameObject);
			GameController.pontos += 100;
			GameController.carros++;
			gc.destroiVida();



			 

		}
	}

}

