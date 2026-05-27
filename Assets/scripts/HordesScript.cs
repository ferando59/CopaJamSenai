using UnityEngine;

public class HordesScript : MonoBehaviour
{

    public GameObject player;
    public GameObject doisOuro;

    private bool HordaEstaEmAndamento = false;

    private float distancia = 0;

    private int kills = 0;


    [Header("Controle de Horda")]
    public int enemiesCount = 15;
    public int enemiesCountControl;
    public bool hordeBool = true;

    [Header("Timer de Horda")]
    public float timerHordeControl = 5f;
    public float timerControl;
    
    void Start()
    {
        enemiesCountControl = enemiesCount;
        timerControl = timerHordeControl;
    }

    
    void Update()
    {
        //Debug.Log("dis " + distancia);
        if(Input.GetKeyDown(KeyCode.K)){

                kills += 1;

            }


        if(distancia >= 49 & distancia <= 50){

            horda1();

        }

        if(distancia >= 99 & distancia <= 100){

            horda2();

        }

         andar(HordaEstaEmAndamento);
    }

    private void andar(bool NaoPode = false){

        if(!NaoPode){

            if(Input.GetKey(KeyCode.W)){

                player.transform.position += transform.up * 3f * Time.deltaTime;
                distancia += 10 * Time.deltaTime;

            }

            /*
            if(Input.GetKey(KeyCode.S)){

                player.transform.position += new Vector3(0f,-0.1f,0f);
                distancia -= 10 * Time.deltaTime;

            }
            */

            if(HordaEstaEmAndamento == true){

                NaoPode = true;

            }else{

                NaoPode = false;

            }

        }

    }

    private void horda1(){

        //inicio
        timerHordeControl -= Time.deltaTime;

        HordaEstaEmAndamento = true;

        if(hordeBool && enemiesCountControl > 0 && timerHordeControl <= 0){
        Instantiate(doisOuro, new Vector3(Random.Range(-9f, 9f), transform.position.y, transform.position.z), transform.rotation);
        enemiesCountControl -= 1;
        Debug.Log("Instanciou" + enemiesCountControl);
        } else if(enemiesCountControl == 0){
        hordeBool = false;
        }

        if(timerHordeControl < 0){
            timerHordeControl = timerControl;

        }

        //enemiesCountControl quantidade de inimigos da horda
        //timerHordeControl tempo de horda
        //hordeBool controle booleano se pode iniciar instancias ou nao

        //fim


        if(kills == 1){

            distancia = 51;
            HordaEstaEmAndamento = false;

        }

    }

    private void horda2(){

        HordaEstaEmAndamento = true;

         if(kills == 2){

             distancia = 101;
             HordaEstaEmAndamento = false;

        }
    }
}
