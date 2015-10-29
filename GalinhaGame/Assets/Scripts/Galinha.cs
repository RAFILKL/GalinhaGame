using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour {

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
	public GameObject spawn4;
	public GameObject spawn5;
    public GameObject spawn6;

    public GameObject galinha;
    public GameObject galinha2;
    public GameObject galinha3;
    public GameObject galinha4;
    public GameObject galinha5;
    public GameObject galinha6;
    private int rand;
    private float timer = 0;
    public static GameObject cloneGalinha1;
    public static GameObject cloneGalinha2;
    public static GameObject cloneGalinha3;
    public static GameObject cloneGalinha4;
    public static GameObject cloneGalinha5;
    public static GameObject cloneGalinha6;
    public static int pontos = 0;
	public static int carros = 5;
	//public static GameObject[] galinhas = new GameObject[100];
	protected int i = 0;
	protected int j = 0;






    // Use this for initialization
    void Start () {

	
	}

    void FixedUpdate ()
    {
        timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update() {


        if (timer > 3) {
            rand = Random.Range(0, 6);
            //ponto 1
            if (rand == 0) {
				cloneGalinha1 = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation) as GameObject;

				Destroy(cloneGalinha1, 10f);
			    				    
				

                
            } else if (rand == 1) {
                cloneGalinha2 = Instantiate(galinha2, spawn2.transform.position, spawn2.transform.rotation) as GameObject;

				Destroy(cloneGalinha2, 10f);
					
                
            } else if (rand == 2) {
                cloneGalinha3 = Instantiate(galinha3, spawn3.transform.position, spawn3.transform.rotation) as GameObject;
				
				Destroy(cloneGalinha3, 10f);
			} else if (rand == 3) {
                cloneGalinha4 = Instantiate(galinha4, spawn4.transform.position, spawn4.transform.rotation) as GameObject;
				
				Destroy(cloneGalinha4, 10f);
			} else if (rand == 4) {
                cloneGalinha5 = Instantiate(galinha5, spawn5.transform.position, spawn5.transform.rotation) as GameObject;
				
				Destroy(cloneGalinha5, 10f);	
			}
            else if (rand == 5)
            {
                cloneGalinha6 = Instantiate(galinha6, spawn6.transform.position, spawn6.transform.rotation) as GameObject;

                Destroy(cloneGalinha6, 10f);
            }

            timer = 0;
        }
    }

     


    

}
