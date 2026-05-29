using UnityEngine;

public class HordesScript : MonoBehaviour
{
    public GameObject[] inimigos;
    public GameObject player;
    //public GameObject doisOuro;
    //public GameObject treisPaus;

    private bool HordaEstaEmAndamento = false;

    private float distancia = 0;

    public int kills = 0;

    int numeroHorda = 1;


    [Header("Controle de Horda")]
    private int enemiesCount = 3;
    private int enemiesCountControl;
    public bool hordeBool = true;

    [Header("Timer de Horda")]
    private float timerHordeControl = 5f;
    private float timerControl;

    public AudioSource HordeAudio;
    public AudioSource motorEngine;

    
    
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

            if(Input.GetKeyDown(KeyCode.W)){

                motorEngine.Play();

            }

             if(Input.GetKeyUp(KeyCode.W)){
                
                motorEngine.Stop();

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

        motorEngine.Stop();

    if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;

        enemiesCountControl = enemiesCount + numeroHorda;

        hordeBool = true;
    }

        //inicio
        timerHordeControl -= Time.deltaTime;

        

        if(hordeBool && enemiesCountControl > 0 && timerHordeControl <= 0){

            int escolha = Random.Range(0, inimigos.Length);

        Instantiate(inimigos[escolha], new Vector3(Random.Range(-8f, 8f), transform.position.y, transform.position.z), transform.rotation);

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


        if(kills == 4){

            distancia = 51;
            HordaEstaEmAndamento = false;
            numeroHorda++;

        }

    }

    private void horda2(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;

        enemiesCountControl = enemiesCount + numeroHorda;

        hordeBool = true;
    }

        //inicio
        timerHordeControl -= Time.deltaTime;

        

        if(hordeBool && enemiesCountControl > 0 && timerHordeControl <= 0){

            int escolha = Random.Range(0, inimigos.Length);

        Instantiate(inimigos[escolha], new Vector3(Random.Range(-8f, 8f), transform.position.y, transform.position.z), transform.rotation);

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

         if(kills == 5){

             distancia = 101;
             HordaEstaEmAndamento = false;
             numeroHorda++;

        }
    }
}
