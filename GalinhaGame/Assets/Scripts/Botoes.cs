using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{

    public GameObject[] spawns;
    public GameObject carro;

    public void clickBotao(int index)
    {
        if (GameController.carros > 0)
        {
            Instantiate(carro, spawns[index].transform.position, spawns[index].transform.rotation);          
            GameController.carros--;
        }

    }
}