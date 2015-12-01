using UnityEngine;
using System.Collections;

public class GalinhaWalk : MonoBehaviour {
    
    
	public int rand, rand2,rand3;
	private int  andar, ciscar,voar, cair;
	public Animator galinhaAnimator;
	public Rigidbody rigGalinha;
	public Animation galinhaAnimation;    
	public float timer, vel;
	public static bool parada, jaPassou, especial;
	public static int valorGalinha;
	public Vector3 velc = new Vector3(0,0,1);

    // Use this for initialization

	void Awake() {
		 jaPassou = false;
		 parada = false;
		 especial = false;
	}
    void Start () {
		andar = Animator.StringToHash ("andar");
		ciscar = Animator.StringToHash ("ciscar");
		voar = Animator.StringToHash ("voar");
		cair = Animator.StringToHash ("cair");
		//Ativa a animaçao da galinha para andar
		galinhaAnimator.SetBool(andar,true);
		galinhaAnimator.SetBool(ciscar,false);
		rigGalinha = GetComponentInChildren<Rigidbody> ();
		rand = Random.Range(1,8);

	}
	void FixedUpdate() {
		timer += Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (parada) {
		} else {
			galinhaAnda ();
		}
	}
	public void testaTrigger(){
		rand2 = Random.Range (4,5);
		// 20% de chance da galinha 
		switch (rand2) {
		case 0:
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			if(!especial) {
			  mudaGalinha();
			  especial = true;
			}
			break;
		}
	
	}
	public void galinhaAnda() {
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

		public void paraGalinha() {	
		   parada = true;
		   transform.Translate (new Vector3(0,0,0));		   
		}



		public void mudaVelocidade(float vel) {	
			if(!parada){
		    float vel2 = vel + 0.4f;			
		    this.transform.Translate (new Vector3(0,0,1) * vel);		    
			galinhaAnimator.speed = vel2;
		    } else {
				this.transform.Translate (velc * 0);		    
				galinhaAnimator.speed = 0;
			}
			
		}
	private void voaGalinha(){
		galinhaAnimator.SetBool (voar, true);
		galinhaAnimator.SetBool (andar,false);
	
		//transform.Translate (Vector3.up * vel);
	}
	private void ciscaGalinha() {
		paraGalinha ();
		galinhaAnimator.SetBool (ciscar, true);
		galinhaAnimator.SetBool(andar,false);

	}
	private void aceleraGalinha() {
		vel += 0.2f;
		mudaVelocidade (vel);

	}
	void mudaGalinha() {
		rand3 = Random.Range(0,3);
		switch (rand3) {
	    //Galinha acelera
		case 0:
			aceleraGalinha();
			break;
		//Galinha voa
		case 1:
			voaGalinha();
			break;
		//Galinha cisca
		case 2:
			ciscaGalinha();
			break;		
		
		}

	}

	void OnTriggerEnter() {
		testaTrigger ();
	}


	
}

