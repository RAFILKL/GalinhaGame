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
	public GameObject textoSCarro;
	public GameObject botaoSCarroNao;
	public GameObject botaoSCarroSim;
	public GameObject[] botoes;
	public static bool naLoja = false;
	private bool perdeuM = false;




	public void entraLoja() {

		if (!naLoja && !perdeuM) {
			textoSCarro.SetActive (false);
			botaoSCarroNao.SetActive (false);
			botaoSCarroSim.SetActive (false);
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
        if (GameController.myStates == GameController.gameStates.perdeu)
        {
            painelPrincipal.SetActive(true);
            botaoPerdeu.SetActive(true);
            textoPerdeu.SetActive(true);
            textoPerdeuPontos.SetActive(true);
            textoPerdeuPontos.GetComponent<Text>().text = GameController.pontos.ToString();
            perdeuM = true;
        }

	}
	public void perdeu() {
		painelPrincipal.SetActive (false);
		botaoComprar.SetActive (false);
		textoPerdeu.SetActive (false);
		textoPerdeuPontos.SetActive (false);
		GameController.pontos = 0;
		GameController.carros = 5;
		Application.LoadLevel ("menu");
		botaoSCarroNao.SetActive (false);
		botaoSCarroSim.SetActive (false);
		textoSCarro.SetActive (false);
		
	}
	public void semCarro(){
       
            painelPrincipal.SetActive(true);
            textoSCarro.SetActive(true);
            botaoSCarroNao.SetActive(true);
            botaoSCarroSim.SetActive(true);
            GameController.myStates = GameController.gameStates.normal;

	    
	}
	public void compraCarro() {
		int aux;
		aux = GameController.pontos - 100;
		if (aux >= 0) {
			GameController.pontos -= 100;
			GameController.carros++;
		}
		
	}

	// CONTROLA BOTAO SIM E NAo

	public void clickNao(){
		Application.LoadLevel ("ScoreBoard");
	}


}
