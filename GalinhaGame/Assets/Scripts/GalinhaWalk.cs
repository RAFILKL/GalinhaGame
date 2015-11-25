using UnityEngine;
using System.Collections;

public class GalinhaWalk : MonoBehaviour {
    
    
	public int rand, rand2;
	private int  andar, ciscar;
	public Animator galinhaAnimator;
	public Animation galinhaAnimation;
	public Rigidbody rig;
    
	private float timer, vel;
	public static bool parada, jaPassou;

    // Use this for initialization
    void Start () {
		andar = Animator.StringToHash ("andar");
		ciscar = Animator.StringToHash ("ciscar");
		//Ativa a animaçao da galinha para andar
		galinhaAnimator.SetBool(andar,true);
		galinhaAnimator.SetBool(ciscar,false);
		rand = Random.Range(1,8);
		parada = false;
		jaPassou = false;
	}
	void FixedUpdate() {
		timer += Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {


		//IA GALINHA
		if (timer > 3) {
			galinhaAnimator.SetBool (andar, true);
			galinhaAnimator.SetBool (ciscar, false);
			rand2 = Random.Range (0, 2);
			switch (rand2) {
			//Galinha continua andando 
			case 0:
				break;
		      //Galinha para
		     case 1:
//				galinhaAnimator.SetBool(andar,false);
//				galinhaAnimator.SetBool(ciscar,true);
//				parada = true;
//				jaPassou = true;
//				mudaVelocidade(0);
			    break;
			}

				timer = 0;
			}
			


			switch (rand) {
			case 1:
			if (parada == false && jaPassou == false) {
					vel = 0.3f;
					mudaVelocidade (vel);
				}
				break;
			case 2:
			   if (parada == false && jaPassou == false) {
			 		vel = 0.5f;
					mudaVelocidade (vel);
				}
				break;
			case 3:
			if (parada == false && jaPassou == false) {
					vel = 0.7f;
					mudaVelocidade (vel);
				}
				break;
			case 4:
			if (parada == false && jaPassou == false) {
					vel = 0.9f;
					mudaVelocidade (vel);
				}
				break;
			case 5:
			if (parada == false && jaPassou == false) {
					vel = 1f;
					mudaVelocidade (vel);
				}
				break;
			case 6:
			if (parada == false && jaPassou == false) {
					vel = 1.2f;				
					mudaVelocidade (vel);
				}
				break;
			case 7:
			if (parada == false && jaPassou == false) {
					vel = 1.3f;
					mudaVelocidade (vel);
				}
				break;
			case 8:
			if (parada == false && jaPassou == false) {
					vel = 1.5f;
					mudaVelocidade (vel);
				}
				break;
			default:
				break;
			}
		}


		public void mudaVelocidade(float vel) {	
		   float vel2 = vel + 0.4f;
		 
		   transform.Translate (Vector3.forward * vel);
		   galinhaAnimator.speed = vel2;
			if (vel > 0) {
				parada = false;
			} else {
				parada = true;
			}
		   
	    }

	
}

