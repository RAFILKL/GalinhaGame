using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour {
	public GameObject galinha;
	public SoundController sc;



	// Use this for initialization
	void Start () {
		sc = GetComponent<SoundController>();

	    
	}

	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision hit) {
		if(hit.gameObject.tag == "Carro") {
			sc.chamaSom();
			Destroy (this.gameObject);
			GameController.pontos++;

			 

		}
	}

}

