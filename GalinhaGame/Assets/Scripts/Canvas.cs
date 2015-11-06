using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Canvas : MonoBehaviour {

    public Text pontos;
	public Text carros;

	// Use this for initialization
	void Start () {
        

	}


	
	// Update is called once per frame
	void Update () {
		pontos.text = "Pontos: " + GameController.pontos;
		carros.text = "Carros: " + GameController.carros;
	}
}
