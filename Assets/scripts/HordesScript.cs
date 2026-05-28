using UnityEngine;

public class HordesScript : MonoBehaviour
{
    public GameObject[] inimigos;
    public GameObject player;
    public GameObject valete;
    //public GameObject treisPaus;

    private bool HordaEstaEmAndamento = false;

    private float distancia = 0;

    public int kills = 0;

    int numeroHorda = 1;

    public int points = 0;


    [Header("Controle de Horda")]
    private int enemiesCount = 3;
    private int enemiesCountControl;

    public bool hordeBool = true;

    [Header("Timer de Horda")]
    private float timerHordeControl = 5f;
    private float timerControl;

    
    
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

        if(distancia >= 149 & distancia <= 150){

            horda3();

        }

        if(distancia >= 199 & distancia <= 200){

            horda4();

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

    if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;

        if(numeroHorda == 4 || numeroHorda == 8 || numeroHorda == 12)
        {
            enemiesCountControl = 1;
        }
        else
        {
            enemiesCountControl = enemiesCount + numeroHorda;
        }

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

            kills = 0;
            distancia = 51;
            HordaEstaEmAndamento = false;
            numeroHorda++;

        }

    }

    private void horda2(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;

        if(numeroHorda == 4 || numeroHorda == 8 || numeroHorda == 12)
        {
            enemiesCountControl = 1;
        }
        else
        {
            enemiesCountControl = enemiesCount + numeroHorda;
        }

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

            timerControl = 4;
            kills = 0;
            distancia = 101;
            HordaEstaEmAndamento = false;
            numeroHorda++;

        }
    }

    private void horda3(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;

        if(numeroHorda == 4 || numeroHorda == 8 || numeroHorda == 12)
        {
            enemiesCountControl = 1;
        }
        else
        {
            enemiesCountControl = enemiesCount + numeroHorda;
        }

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

         if(kills == 6){

            timerControl = 3;
            kills = 0;
            distancia = 151;
            HordaEstaEmAndamento = false;
            numeroHorda++;

        }
    }

    private void horda4(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;

        if(numeroHorda == 4 || numeroHorda == 8 || numeroHorda == 12)
        {
            enemiesCountControl = 1;
        }
        else
        {
            enemiesCountControl = enemiesCount + numeroHorda;
        }

        hordeBool = true;
    }

        //inicio
        timerHordeControl -= Time.deltaTime;

        

        if(hordeBool && enemiesCountControl > 0 && timerHordeControl <= 0){

            

        Instantiate(valete, transform.position, transform.rotation);

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

            timerControl = 3;
            kills = 0;
            distancia = 201;
            HordaEstaEmAndamento = false;
            numeroHorda++;

        }
    }
}
