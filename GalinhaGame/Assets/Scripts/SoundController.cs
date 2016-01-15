using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour  {
	public AudioClip[] gemidos;
	public AudioSource audioManager;
	private int rand;


	public void chamaSom(int index) {
			audioManager.clip = gemidos[index];
			audioManager.Play ();
	}

}
