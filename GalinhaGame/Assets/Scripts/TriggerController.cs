using UnityEngine;
using System.Collections;

public class TriggerController : MonoBehaviour {

	public GameObject gal;


    void OnTriggerEnter(Collider objectCollider)
    {
        GalinhaWalk Galinha = objectCollider.gameObject.GetComponent<GalinhaWalk>();
        if (Galinha != null) {
            Debug.LogFormat("Galinha {0} entrou no trigger {1}", Galinha.gameObject.name, gameObject.name);           
            Galinha.testaTrigger();
        }       
    }
}
