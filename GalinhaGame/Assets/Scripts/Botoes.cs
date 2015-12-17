using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Botoes : MonoBehaviour {

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
	public GameObject spawn4;
	public GameObject spawn5;
    public GameObject carro;
    private GameObject cloneCarro;

	private float timer = 0;

	void FixedUpdate() {
		timer += Time.deltaTime;
	}

	public void botclick1()  {
			if (GameController.carros > 0) {
				cloneCarro = Instantiate (carro, spawn1.transform.position, spawn1.transform.rotation) as GameObject;
				GameController.carros--;
		}
		
	}

    public void botclick2()	{
			if (GameController.carros > 0) {
				cloneCarro = Instantiate (carro, spawn2.transform.position, spawn2.transform.rotation) as GameObject;
				GameController.carros--;				

		}
	}
    public void botclick3() {
			if (GameController.carros > 0) {
				cloneCarro = Instantiate (carro, spawn3.transform.position, spawn3.transform.rotation) as GameObject;
				GameController.carros--;
		}
	}
    public void botclick4() {
			if (GameController.carros > 0) {
			cloneCarro = Instantiate (carro, spawn4.transform.position, spawn4.transform.rotation) as GameObject;
			GameController.carros--;
		}
	}
    public void botclick5() {
			if (GameController.carros > 0) {
				cloneCarro = Instantiate (carro, spawn5	.transform.position, spawn5.transform.rotation) as GameObject;
				GameController.carros--;
		}
	}


    

}
