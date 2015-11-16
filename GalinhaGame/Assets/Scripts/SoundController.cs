using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour  {
	public AudioClip gem1,gem2,gem3;
	public AudioSource audioManager;
	public int rand;
	void Start() {
		Debug.Log ("Oi");
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
