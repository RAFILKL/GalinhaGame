using UnityEngine;
using System.Collections;

public class CarroWalk : MonoBehaviour {

      public float speedMove = 3f;
	  public GameObject galinha;
	  public  AudioClip[] gem;
	  public  AudioSource audioManager;
	  public  int rand;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        transform.Translate(Vector3.down * speedMove);
        Destroy(gameObject, 5f);

    }


	
	public void chamaSom() {
		rand = Random.Range(0,5);
		switch (rand) {
		case 0:
			audioManager.clip = gem[0];
			audioManager.Play ();
			break;
		case 1:
			audioManager.clip = gem[1];
			audioManager.Play ();
			break;
		case 2:
			audioManager.clip = gem[2];
			audioManager.Play ();
			break;
		case 3:
			audioManager.clip = gem[3];
			audioManager.Play ();
			break;
		case 4:
			audioManager.clip = gem[4];
			audioManager.Play ();
			break;
		case 5:
			audioManager.clip = gem[5];
			audioManager.Play ();
			break;
		}
		
		
	}





}

