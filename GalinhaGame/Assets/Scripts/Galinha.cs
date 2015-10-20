using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour {

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject galinha;
    private int rand;
    private float timer = 0;
    private float timer2 = 0;
    private GameObject cloneGalinha;

    // Use this for initialization
    void Start () {
	
	}

    void FixedUpdate ()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
    }

    // Update is called once per frame
    void Update() {

        if (timer > 6) {
            rand = Random.Range(0, 3);
            //ponto 1
            if (rand == 0)
            {
                Debug.Log(timer);
                if (timer > 6)
                {

                    cloneGalinha = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation) as GameObject;
                    

                }

                if (timer2 > 12)
                {


                    Destroy(cloneGalinha);
                    timer2 = 6;

                }
            }
            timer = 0;
            //ponto 2
            if (rand == 1)
            {
                Debug.Log(timer);
                if (timer > 6)
                {

                    cloneGalinha = Instantiate(galinha, spawn2.transform.position, spawn2.transform.rotation) as GameObject;

                }

                if (timer2 > 12)
                {


                    Destroy(cloneGalinha);
                    timer2 = 6;

                }
            }
            timer = 0;
            //ponto 3
            if (rand == 2)
            {
                Debug.Log(timer);
                if (timer > 6)
                {

                    cloneGalinha = Instantiate(galinha, spawn3.transform.position, spawn3.transform.rotation) as GameObject;

                }

                if (timer2 > 12)
                {


                    Destroy(cloneGalinha);
                    timer2 = 6;

                }
            }
            timer = 0;
        }









        //Rigidbody cloneGalinha;
        //cloneGalinha = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation)as Rigidbody;


    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("tocou2");
        if (hit.gameObject.tag == "Parede")
        {
            Debug.Log("tocou");
            Destroy(galinha);
        }

    }
}
