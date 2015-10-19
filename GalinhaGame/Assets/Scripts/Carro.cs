using UnityEngine;
using System.Collections;

public class Carro : MonoBehaviour {

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject botao1;
    public GameObject carro;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            BoxCollider cloneGalinha;
            cloneGalinha = Instantiate(carro, spawn1.transform.position, spawn1.transform.rotation) as BoxCollider;
        }
        /*if (Input.GetMouseButtonDown(0))
        {
            BoxCollider cloneGalinha;
            cloneGalinha = Instantiate(carro, spawn2.transform.position, spawn2.transform.rotation) as BoxCollider;
        }
        if (Input.GetMouseButtonDown(0))
        {
            BoxCollider cloneGalinha;
            cloneGalinha = Instantiate(carro, spawn3.transform.position, spawn3.transform.rotation) as BoxCollider;
        }*/

    }
}
