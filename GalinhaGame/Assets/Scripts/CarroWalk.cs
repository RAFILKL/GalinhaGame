using UnityEngine;
using System.Collections;

public class CarroWalk : MonoBehaviour {

      public float speedMove;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * speedMove);


    }

}

