using UnityEngine;
using System.Collections;

public class GalinhaWalk : MonoBehaviour {
    
    
	public int rand;
	public Animator galinhaAnimator;


    // Use this for initialization
    void Start () {
		//Ativa a animaçao da galinha para andar
		galinhaAnimator.SetBool("andar", true);
		galinhaAnimator.SetBool("ciscar", false);
		rand = Random.Range(0,9);
	}
	void FixedUpdate() {
	
	}
	
	// Update is called once per frame
	void Update () {


		switch (rand) {
		case 1:
			transform.Translate(Vector3.forward * 0.3f);
			break;
		case 2:
			transform.Translate(Vector3.forward * 0.4f);
			break;
		case 3:
			transform.Translate(Vector3.forward * 0.6f);
			break;
		case 4:
			transform.Translate(Vector3.forward * 0.7f);
			break;
		case 5:
			transform.Translate(Vector3.forward * 0.8f);
			break;
		case 6:
			transform.Translate(Vector3.forward * 1);
			break;
		case 7:
			transform.Translate(Vector3.forward * 1.1f);
			break;
		case 8:
			transform.Translate(Vector3.forward * 1.2f);
			break;
		}




    }



  


}
