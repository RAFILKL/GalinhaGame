using UnityEngine;
using System.Collections;

public class GalinhaWalk : MonoBehaviour
{


    public int rand, rand2, rand3;
    private int andar, ciscar, voar, acelerar;
    public Animator galinhaAnimator;
    public Animation galinhaAnimation;
    public float timer, vel, velSpeed;
    public bool parada, especial;
    public static bool outraParada = false;
    public static int valorGalinha;
    public Vector3 velc = new Vector3(0, 0, 1);

    const int Easy = 2;
    const int Medium = 3;
    const int Hard = 4;
    const int Nivel = Easy;

    // Use this for initialization

    void Awake()
    {
        parada = false;
        especial = false;
        flySpeed = 0;
    }
    void Start()
    {
        andar = Animator.StringToHash("andar");
        ciscar = Animator.StringToHash("ciscar");
        voar = Animator.StringToHash("voar");
        acelerar = Animator.StringToHash("acelerar");
        //Ativa a animaçao da galinha para andar
        galinhaAnimator.SetBool(andar, true);
        galinhaAnimator.SetBool(ciscar, false);
        rand = Random.Range(1, 8);

    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!parada)
        {
            galinhaAnda();
        }
    }
    public void testaTrigger()
    {
        rand2 = Random.Range(0, 5);

        // 20% de chance da galinha 
#if UNITY_EDITOR
        if(!outraParada && !especial)
//#else
        if (rand2 == 4  && !outraParada && !especial)
#endif
        {
            outraParada = true;
            mudaGalinha();
            Debug.Log("GAlinha especial!");
            this.especial = true;
        }
    }

    IEnumerator AguardaGalinha()
    {
        parada = true;
        Debug.LogFormat("Galinha {0} parou!", gameObject.name);
        yield return new WaitForSeconds(2f);
        Debug.LogFormat("Galinha {0} andou!", gameObject.name);
        parada = false;
        outraParada = false;
        galinhaAnimator.SetBool(ciscar, false);
        galinhaAnimator.SetBool(andar, true);
    }

    public void galinhaAnda()
    {
        outraParada = false;
        switch (rand)
        {
            case 1:
                if (!parada)
                {
                    vel = 0.3f;
                    valorGalinha = 30;
                    this.mudaVelocidade(vel);
                }
                break;
            case 2:
                if (!parada)
                {
                    vel = 0.5f;
                    valorGalinha = 30;
                    this.mudaVelocidade(vel);
                }
                break;
            case 3:
                if (!parada)
                {
                    vel = 0.7f;
                    valorGalinha = 30;
                    this.mudaVelocidade(vel);

                }
                break;
            case 4:
                if (!parada)
                {
                    vel = 0.9f;
                    valorGalinha = 35;
                    this.mudaVelocidade(vel);
                }
                break;
            case 5:
                if (!parada)
                {
                    vel = 1f;
                    valorGalinha = 45;
                    this.mudaVelocidade(vel);
                }
                break;
            case 6:
                if (!parada)
                {
                    vel = 1.2f;
                    valorGalinha = 55;
                    this.mudaVelocidade(vel);
                }
                break;
            case 7:
                if (!parada)
                {
                    vel = 1.3f;
                    valorGalinha = 65;
                    this.mudaVelocidade(vel);
                }
                break;
            case 8:
                if (!parada)
                {
                    vel = 1.5f;
                    valorGalinha = 75;
                    this.mudaVelocidade(vel);
                }
                break;
        }
    }


    public void paraGalinha()
    {
        foreach (GalinhaWalk Galinha in FindObjectsOfType<GalinhaWalk>())
        {
            if (Galinha.GetInstanceID() != this.GetInstanceID())
            {
                //Galinha.transform.Translate(Vector3.zero);
                //Galinha.parada = true;
                if (Galinha.parada)
                {
                    Galinha.parada = false;
                  
                }
            }
        }

        especial = true;
        parada = true;
    }


    public float multiplier = 1f;
    public void mudaVelocidade(float vel)
    {
        float vel2 = (vel + 0.4f) * multiplier * Time.deltaTime;
        this.transform.Translate(velc * vel);
        galinhaAnimator.speed = vel2;



    }
    IEnumerator VoaGalinha()
    {
        flySpeed = 0;
        for (int i = 1; i < 11; i++)
        {
            flySpeed += i * 7;
            transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(1f);
        galinhaAnimator.SetBool(voar, false);
        galinhaAnimator.SetBool(andar, true);
    }

    public float flySpeed = 1f;
    public void voaGalinha()
    {        
        parada = true;
        galinhaAnimator.speed = 0.05f;
        galinhaAnimator.SetBool(voar, true);
        galinhaAnimator.SetBool(andar, false);
        StartCoroutine(VoaGalinha());
        parada = false;
    }
  
    void ciscaGalinha()
    {
        StartCoroutine(AguardaGalinha());
        paraGalinha();
        galinhaAnimator.SetBool(ciscar, true);
        galinhaAnimator.SetBool(andar, false);
    }
    IEnumerator AceleraGalinha()
    {
        galinhaAnimator.SetBool(andar,false);
        galinhaAnimator.SetBool(acelerar,true);
        velSpeed = vel;
        parada = true;
        for (int i = 1; i < 30; i++)
        {
           
            velSpeed += 0.15f;          
            this.transform.Translate(velc * velSpeed);
            galinhaAnimator.speed = velSpeed;
            yield return new WaitForSeconds(0.01f);
        }
        parada = false;
        galinhaAnimator.SetBool(andar, true);
        galinhaAnimator.SetBool(acelerar, false);
    }


    void mudaGalinha()
    {
        rand3 = Random.Range(0, 3);
        switch (rand3)
        {
            //Galinha acelera
            case 0:
                StartCoroutine(AceleraGalinha());
                break;
            //Galinha voa
            case 1:
                Debug.Log("VOou");
                voaGalinha();
                break;
            //Galinha cisca
            case 2:
                ciscaGalinha();
                break;

        }
    }
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Galinha")
        {
            transform.Translate(1.5f,0,0);
            col.gameObject.transform.Translate(1.5f, 0, 0);
                
        }
    }
}