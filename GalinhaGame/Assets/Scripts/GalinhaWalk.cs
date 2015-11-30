using UnityEngine;
using System.Collections;

public class GalinhaWalk : MonoBehaviour {
    
    
	public int rand, rand2;
	private int  andar, ciscar;
	public Animator galinhaAnimator;
	public Animation galinhaAnimation;    
	public float timer, vel;
	public static bool parada, jaPassou;
	public static int valorGalinha;

    // Use this for initialization

	void Awake() {
		 jaPassou = false;
		 parada = false;
	}
    void Start () {
		andar = Animator.StringToHash ("andar");
		ciscar = Animator.StringToHash ("ciscar");
		//Ativa a animaçao da galinha para andar
		galinhaAnimator.SetBool(andar,true);
		galinhaAnimator.SetBool(ciscar,false);
		rand = Random.Range(1,8);


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
				//mudaVelocidade(vel);
			    break;
			}

				timer = 0;
			}
			


			switch (rand) {
			case 1:
			if (parada == false && jaPassou == false) {
					vel = 0.3f;
				    valorGalinha = 30;
					mudaVelocidade (vel);
				   // jaPassou = true;
				}
				break;
			case 2:
			   if (parada == false && jaPassou == false) {
			 		vel = 0.5f;
				    valorGalinha = 30;
					mudaVelocidade (vel);
				//	jaPassou = true;
				}
				break;
			case 3:
			if (parada == false && jaPassou == false) {
					vel = 0.7f;
				    valorGalinha = 30;
					mudaVelocidade (vel);
				//	jaPassou = true;
				}
				break;
			case 4:
			if (parada == false && jaPassou == false) {
					vel = 0.9f;
				    valorGalinha = 35;
					mudaVelocidade (vel);
				//	jaPassou = true;
				}
				break;
			case 5:
			if (parada == false && jaPassou == false) {
					vel = 1f;
				    valorGalinha = 45;
					mudaVelocidade (vel);
				//	jaPassou = true;
				}
				break;
			case 6:
			if (parada == false && jaPassou == false) {
					vel = 1.2f;			
				    valorGalinha = 55;
					mudaVelocidade (vel);
				//	jaPassou = true;
				}
				break;
			case 7:
			if (parada == false && jaPassou == false) {
					vel = 1.3f;
				    valorGalinha = 65;
					mudaVelocidade (vel);
				//	jaPassou = true;
				}
				break;
			case 8:
			if (parada == false && jaPassou == false) {
					vel = 1.5f;
				    valorGalinha = 75;
					mudaVelocidade (vel);
					jaPassou = true;
				}
				break;
			default:
				break;
			}
			}
		public void paraGalinha(float vel) {				
			transform.Translate (Vector3.forward * -(vel));			
			
		}



	public void mudaVelocidade(float vel) {	
		float vel2 = vel + 0.4f;
		
		transform.Translate (Vector3.forward * vel);
		galinhaAnimator.speed = vel2;
		if (vel >= 0) {
			parada = false;
		} else {
			parada = true;
		}
		
	}

	
}

