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

        Destroy(gameObject, 2.3f);

    }


    void OnCollisionEnter(Collision hit)
    {
        Debug.Log("tocou1");
        if (hit.gameObject.name == "Galinha(Clone)")
        {
            Debug.Log("tocou");
            Destroy(Galinha.cloneGalinha);
            Galinha.pontos++;
        }

    }

}

