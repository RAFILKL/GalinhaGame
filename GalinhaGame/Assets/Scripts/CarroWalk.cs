using UnityEngine;
using System.Collections;

public class CarroWalk : MonoBehaviour
{

    public float speedMove = 3f;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * speedMove);
        Destroy(gameObject, 5f);

    }


}

