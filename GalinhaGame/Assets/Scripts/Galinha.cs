using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour {

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
	public GameObject spawn4;
	public GameObject spawn5;

    public GameObject galinha;
    private int rand;
    private float timer = 0;
    public static GameObject cloneGalinha;
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


        if (timer > 4) {
            rand = Random.Range(-1, 5);
            //ponto 1
            if (rand == 0) {	
				cloneGalinha = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation) as GameObject;

				Destroy(cloneGalinha, 10f);
			    				    
				

                
            } else if (rand == 1) {
				cloneGalinha = Instantiate(galinha, spawn2.transform.position, spawn2.transform.rotation) as GameObject;

				Destroy(cloneGalinha, 10f);
					
                
            } else if (rand == 2) {

				cloneGalinha = Instantiate(galinha, spawn3.transform.position, spawn3.transform.rotation) as GameObject;
				
				Destroy(cloneGalinha, 10f);
			} else if (rand == 3) {
				cloneGalinha = Instantiate(galinha, spawn4.transform.position, spawn4.transform.rotation) as GameObject;
				
				Destroy(cloneGalinha, 10f);
			} else if (rand == 4) {
				
				cloneGalinha = Instantiate(galinha, spawn5.transform.position, spawn5.transform.rotation) as GameObject;
				
				Destroy(cloneGalinha, 10f);	
			} 
            
            timer = 0;
        }









        //Rigidbody cloneGalinha;
        //cloneGalinha = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation)as Rigidbody;


    }

     


    

}
