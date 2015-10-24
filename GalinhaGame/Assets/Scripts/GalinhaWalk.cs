using UnityEngine;
using System.Collections;

public class GalinhaWalk : MonoBehaviour {
    
    public float speedMove;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		transform.Translate(Vector3.forward * speedMove/2);


    }

  
	 void OnCollisionEnter(Collision hit) {
		Debug.Log ("Tocou");
	   if (hit.gameObject.name == "GalinhaPrefab(Clone)") {
			transform.Translate(Vector3.back * speedMove/2);		
	
	  }
	}
}
