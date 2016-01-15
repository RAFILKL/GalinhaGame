using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{

    public GameObject[] spawns;
    private GameObject[] clonegalinha;
    public GameObject galinha;
    public UIController UI;
    private int rand;
    public static int pontos = 0;
    public static int carros = 5;
    public static bool sCarro = false;
    public static bool perdeu = false;
    public enum gameStates { normal, semCarro, perdeu };
    public static gameStates myStates;




    void Start()
    {
        myStates = gameStates.normal;
        InvokeRepeating("spawnGalinha", 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(myStates);
        if (myStates == gameStates.normal)
        {
            if (carros == 0 && !UIController.naLoja)
                myStates = gameStates.semCarro;
            if (pontos < 100 && carros == 0)
                myStates = gameStates.perdeu;

            if (myStates == gameStates.perdeu) 
            {
                StartCoroutine(perdeuJogo());
            }
            else if (myStates == gameStates.semCarro)
            {
                StartCoroutine(semCarro());
            }
            else
            {
                myStates = gameStates.normal;
            }
        }
    }


    IEnumerator semCarro()
    {
        yield return new WaitForSeconds(3f);
        if (carros == 0 && myStates == gameStates.semCarro)
        {
            UI.semCarro();
        }
        else
        {
            myStates = gameStates.normal;
        }

   
    }
    IEnumerator perdeuJogo()
    {      
        yield return new WaitForSeconds(3.1f);
        if (pontos < 100 && carros == 0)
        {
            UI.mostraPerdeu();
        }
        else
        {
            myStates = gameStates.normal;
        }
    }


    void spawnGalinha()
    {
        rand = Random.Range(0, 6);
        addGalinha(rand);
    }

    void addGalinha(int index)
    {
        Instantiate(galinha, spawns[index].transform.position, spawns[index].transform.rotation);


    }
}









