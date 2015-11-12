using UnityEngine;
using System.Collections;

public class CarroWalk : MonoBehaviour {

      public float speedMove = 3f;
	  public GameObject galinha;
	  public  AudioClip gem1,gem2,gem3;
	  public  AudioSource audioManager;
	  public  int rand;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        transform.Translate(Vector3.forward * speedMove);
        Destroy(gameObject, 5f);

    }


	
	public void chamaSom() {
		rand = Random.Range(0,2);
		switch (rand) {
		case 0:
			audioManager.clip = gem1;
			audioManager.Play ();
			break;
		case 1:
			audioManager.clip = gem2;
			audioManager.Play ();
			break;
		case 2:
			audioManager.clip = gem3;
			audioManager.Play ();
			break;
		}
		
		
	}





}

