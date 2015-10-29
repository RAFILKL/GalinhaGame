using UnityEngine;
using System.Collections;

public class GalinhaWalk : MonoBehaviour {
    
    
	public int rand, rand2;
	public Animator galinhaAnimator;
	public Animation galinhaAnimation;
	private float timer;


    // Use this for initialization
    void Start () {
		//Ativa a animaçao da galinha para andar
		galinhaAnimator.SetBool("andar", true);
		galinhaAnimator.SetBool("ciscar", false);
		rand = Random.Range(1,8);

	}
	void FixedUpdate() {
		timer += Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {


		// IA GALINHA
		 if(timer > 3) {
			rand2 = Random.Range (0,1);
		    switch(rand2) {
			  //Galinha continua andando 
			case 0:
				break;
		      //Galinha para
			case 1:
				transform.Translate(Vector3.forward * 0);
				break;
			}
		 }
		timer = 0;


		switch (rand) {
		case 1:
			transform.Translate(Vector3.forward * 0.3f);
			galinhaAnimator.speed = 0.3f;
			break;
		case 2:
			transform.Translate(Vector3.forward * 0.4f);
			galinhaAnimator.speed = 0.4f;
			break;
		case 3:
			transform.Translate(Vector3.forward * 0.6f);
			galinhaAnimator.speed = 0.7f;
			break;
		case 4:
			transform.Translate(Vector3.forward * 0.7f);
			galinhaAnimator.speed = 0.8f;
			break;
		case 5:
			transform.Translate(Vector3.forward * 0.8f);
			galinhaAnimator.speed = 1;
			break;
		case 6:
			transform.Translate(Vector3.forward * 1);
			galinhaAnimator.speed = 1.2f;
			break;
		case 7:
			transform.Translate(Vector3.forward * 1.1f);
			galinhaAnimator.speed = 1.3f;
			break;
		case 8:
			transform.Translate(Vector3.forward * 1.2f);
			galinhaAnimator.speed = 1.7f;
			break;
		}


	



    }


  


}
