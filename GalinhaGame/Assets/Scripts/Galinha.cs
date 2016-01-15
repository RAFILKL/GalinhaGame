using UnityEngine;
using System.Collections;

public class Galinha : MonoBehaviour
{
    public GameObject galinha;    
    SoundController sc;
    private float timer = 0;
    private int index;



    // Use this for initialization
    void Start()
    {
        galinha = GameObject.FindGameObjectWithTag("SoundController");
        sc = galinha.GetComponent<SoundController>();

    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }
    void Update()
    {
        if(timer > 12f) {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Carro")
        {
            sc.chamaSom(Random.Range(0, 6));
            Destroy(this.gameObject);
            GameController.pontos += GalinhaWalk.valorGalinha;
            GameController.carros++;

        }
    }

}

