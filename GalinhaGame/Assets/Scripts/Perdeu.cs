using UnityEngine;
using System.Collections;

public class Perdeu : MonoBehaviour {

    public GameObject galinha;
    public GameObject parede;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    

	}

    void OnCollisionEnter(Collision parede)
    {
        Debug.Log("Adentrou");
        //pontos++;
        DestroyObject(galinha);
    }
}
