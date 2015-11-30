using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public GameObject painelPrincipal;
	public GameObject painelComprarCarro;
	public GameObject scrollBar;
	public Button botaoLoja;
	public GameObject botaoComprar;
	public GameObject textoComprarCarro;
	public GameObject botaoPerdeu;
	public GameObject textoPerdeu;
	public GameObject textoPerdeuPontos;
	public GameObject[] botoes;
	private Text text;
	private bool naLoja = false;
	private bool perdeuM = false;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
	

	}



	public void entraLoja() {
		if (!naLoja && !perdeuM) {
			painelPrincipal.SetActive(true);
			painelComprarCarro.SetActive(true);
			botaoComprar.SetActive(true);
			textoComprarCarro.SetActive(true);
			scrollBar.SetActive(true);
			naLoja = true;
			for(int i = 0; i < botoes.Length; i++) {
				botoes[i].SetActive(false);
			}
		} else {
			painelPrincipal.SetActive(false);
			painelComprarCarro.SetActive(false);
			botaoComprar.SetActive(false);
			textoComprarCarro.SetActive(false);
			scrollBar.SetActive(false);
			naLoja = false;
			for(int i = 0; i < botoes.Length; i++) {
				botoes[i].SetActive(true);
			}
		}
	}
	public void mostraPerdeu() {
		painelPrincipal.SetActive (true);
		botaoPerdeu.SetActive (true);
		textoPerdeu.SetActive (true);
		textoPerdeuPontos.SetActive (true);
		textoPerdeuPontos.GetComponent<Text> ().text = GameController.pontos.ToString();
		perdeuM = true;

	}
	public void perdeu() {
		painelPrincipal.SetActive (false);
		botaoComprar.SetActive (false);
		textoPerdeu.SetActive (false);
		textoPerdeuPontos.SetActive (false);
		GameController.pontos = 0;
		GameController.carros = 5;
		Application.LoadLevel ("menu");
		GameController.passou = false;
		
	}
	public void compraCarro() {
		int aux;
		aux = GameController.pontos - 100;
		if (aux >= 0) {
			GameController.pontos -= 100;
			GameController.carros++;
		}
		
	}




}
