using UnityEngine;
using System.Collections;

public class CarroWalk : MonoBehaviour {

      public float speedMove = 3f;
	  public GameObject galinha;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {

        transform.Translate(Vector3.forward * speedMove);

        Destroy(gameObject, 5f);

    }





}

