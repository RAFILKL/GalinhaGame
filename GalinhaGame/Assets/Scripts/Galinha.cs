using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour {

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject galinha;
    private int rand;
    private float timer = 0;

    // Use this for initialization
    void Start () {
	
	}

    void FixedUpdate ()
    {
        timer += Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {

        
        Debug.Log(timer);
        if (timer > 3)
        {

            rand = Random.Range(0, 3);
            if (rand == 0)
            {
                BoxCollider cloneGalinha;
                cloneGalinha = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation) as BoxCollider;
            }
            else
            if (rand == 1)
            {
                BoxCollider cloneGalinha;
                cloneGalinha = Instantiate(galinha, spawn2.transform.position, spawn2.transform.rotation) as BoxCollider;
            }
            else
            if (rand == 2)
            {
                BoxCollider cloneGalinha;
                cloneGalinha = Instantiate(galinha, spawn3.transform.position, spawn3.transform.rotation) as BoxCollider;
            }
            timer = 0;


        }
        


        //Rigidbody cloneGalinha;
        //cloneGalinha = Instantiate(galinha, spawn1.transform.position, spawn1.transform.rotation)as Rigidbody;


    }

}
