using UnityEngine;
using System.Collections;

public class GameController: MonoBehaviour {

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
	public GameObject spawn4;
	public GameObject spawn5;
    public GameObject spawn6;
	private GameObject clonegalinha, clonegalinha2,clonegalinha3,clonegalinha4,clonegalinha5, clonegalinha6;
	public  GameObject vida1,vida2,vida3;
	public  GameObject galinha;
	public UIController UI;
    private int rand;
	private float timer = 0;
	private float timer2 = 0;
	public static int pontos = 0;
	public static int carros = 5;
	public static bool sCarro = false;
	public static bool perdeu = false;
	private bool verifica = false;
	public static bool carroEmCena = false;
	public static bool passou = false;






    // Use this for initialization
	void Start () {


	}

    void FixedUpdate ()  {
        timer += Time.deltaTime;

    }

    // Update is called once per frame
    void Update() {
		if(pontos < 100 && carros == 0){
			timer2 += Time.deltaTime;
			if(timer2 > 3) {
				UI.mostraPerdeu();
				timer = 0;
			}
		
		}
        if (timer > 3) {
            rand = Random.Range(0, 5);
            //ponto 1
            if (rand == 0) {
				clonegalinha = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation)as GameObject;
				Destroy(clonegalinha, 10f);
            } else if (rand == 1) {
				clonegalinha2 = Instantiate(galinha, spawn2.transform.position, spawn2.transform.rotation) as GameObject;
				Destroy(clonegalinha2, 10f);
            } else if (rand == 2) {
				clonegalinha3 = Instantiate(galinha, spawn3.transform.position, spawn3.transform.rotation) as GameObject;
				Destroy(clonegalinha3, 10f);
			} else if (rand == 3) {
				clonegalinha4 = Instantiate(galinha, spawn4.transform.position, spawn4.transform.rotation) as GameObject;
				Destroy(clonegalinha4, 10f);
			} else if (rand == 4) {
			    clonegalinha5 = Instantiate(galinha, spawn5.transform.position, spawn5.transform.rotation) as GameObject;
				Destroy(clonegalinha5, 10f);
			} else if (rand == 5) {
				clonegalinha6 = Instantiate(galinha, spawn6.transform.position, spawn6.transform.rotation) as GameObject;
				Destroy(clonegalinha6, 10f);          
		
            }

            timer = 0;
        }

	}

}

