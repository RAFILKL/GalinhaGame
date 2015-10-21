using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {

    public Text texto;

	// Use this for initialization
	void Start () {
        texto = GetComponent<Text>();
	}


	
	// Update is called once per frame
	void Update () {
        texto.text = "Pontos: " + Galinha.pontos;
	}
}
