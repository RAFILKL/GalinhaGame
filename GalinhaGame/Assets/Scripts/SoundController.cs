using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour  {
	public AudioClip[] gemidos;
	public AudioSource audioManager;
	public int rand;

	public void chamaSom() {
		rand = Random.Range(0,5);
		switch (rand) {
		case 0:
			audioManager.clip = gemidos[0];
			audioManager.Play ();
			break;
		case 1:
			audioManager.clip = gemidos[1];		
			audioManager.Play ();
			break;
		case 2:
			audioManager.clip = gemidos[2];
			audioManager.Play ();
			break;		
		case 3:
			audioManager.clip = gemidos[3];
		    audioManager.Play ();
		    break;
		case 4:
			audioManager.clip = gemidos[4];
			audioManager.Play ();
			break;
		case 5:
			audioManager.clip = gemidos[5];
			audioManager.Play ();
			break;
		
	}

	}

}
