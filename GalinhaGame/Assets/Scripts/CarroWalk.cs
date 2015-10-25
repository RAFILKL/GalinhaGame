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
    void Update()
    {

        transform.Translate(Vector3.forward * speedMove);

        Destroy(gameObject, 5f);

    }

	void OnCollisionEnter(Collision hit)
	{
		
		if (hit.gameObject.name == "GalinhaPrefab(Clone)")
		{		
			Destroy(Galinha.cloneGalinha1);
			Galinha.pontos++;
			Galinha.carros++;
			
		}
        if (hit.gameObject.name == "GalinhaPrefab_2(Clone)")
        {
            Destroy(Galinha.cloneGalinha2);
            Galinha.pontos++;
            Galinha.carros++;

        }
        if (hit.gameObject.name == "GalinhaPrefab_3(Clone)")
        {
            Destroy(Galinha.cloneGalinha3);
            Galinha.pontos++;
            Galinha.carros++;

        }
        if (hit.gameObject.name == "GalinhaPrefab_4(Clone)")
        {
            Destroy(Galinha.cloneGalinha4);
            Galinha.pontos++;
            Galinha.carros++;

        }
        if (hit.gameObject.name == "GalinhaPrefab_5(Clone)")
        {
            Destroy(Galinha.cloneGalinha5);
            Galinha.pontos++;
            Galinha.carros++;

        }

    }
	

   

}

