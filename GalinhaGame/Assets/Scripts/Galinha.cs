using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour {
	public GameObject galinha;

	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision hit) {
		if(hit.gameObject.tag == "Carro") {
			Destroy (this.gameObject);

		}
	}


}

