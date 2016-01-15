using UnityEngine;
using System.Collections;

public class GalinhaMenu : MonoBehaviour
{


    public Camera cameraa;
    public GameObject gal;
    Vector3 galPos;
    // Update is called once per frame
    void Update()
    {
        galPos = gal.transform.position;
        cameraa.transform.LookAt(galPos);
    }
}