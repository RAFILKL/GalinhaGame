using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public GameObject painel;
	public GameObject botaoComprar;
	public GameObject botaoSair;
	public GameObject texto;
	public GameObject botaoPerdeu;
	public GameObject textoPerdeu;
	public GameObject textoPerdeuPontos;
	private Text text;

	// Use this for initialization
	void Start () {
		textoPerdeuPontos.GetComponent<Text> ().text = "oi" + GameController.pontos.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void sCarro() {
	  if (GameController.pontos >= 70 || GameController.carros != 0) {
			painel.SetActive (true);
			botaoComprar.SetActive (true);
			botaoSair.SetActive (true);
			texto.SetActive (true);
		} else {
			botaoComprar.SetActive (false);
			botaoSair.SetActive (false);
			texto.SetActive (false);
			mostraPerdeu();
		}
		
	}
	public void mostraPerdeu() {

		painel.SetActive (true);
		botaoPerdeu.SetActive (true);
		textoPerdeu.SetActive (true);
		textoPerdeuPontos.SetActive (true);


	}
	public void perdeu() {
		painel.SetActive (false);
		botaoComprar.SetActive (false);
		botaoSair.SetActive (false);
		textoPerdeu.SetActive (false);
		textoPerdeuPontos.SetActive (false);
		GameController.pontos = 0;
		GameController.carros = 3;
		Application.LoadLevel ("menu");
		GameController.passou = false;
		
	}
	public void compraCarro() {
		int aux;
		aux = GameController.pontos - 70;
		if (aux > 0) {
			GameController.pontos -= 70;
			GameController.carros++;
		}
		
	}

	public void sairCompraCarro() {
		   if (GameController.carros != 0) {
			painel.SetActive (false);
			botaoComprar.SetActive (false);
			botaoSair.SetActive (false);
			texto.SetActive (false);
			GameController.passou = false;

		} 


		
	}



}
