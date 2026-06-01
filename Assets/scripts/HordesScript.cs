using UnityEngine;
using UnityEngine.SceneManagement;

public class HordesScript : MonoBehaviour
{
    public GameObject[] inimigos;
    public GameObject player;
    public GameObject valete;
    public GameObject ass;
    public GameObject drones;

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
     public AudioSource radioAudio;
    public AudioClip enemyInComming;
    public AudioClip allCleared;
    public AudioClip bigOne;

    public AudioClip click;

    public float winGameTimer = 120;

    CopasGunsControler CGC;

    
    
    void Start()
    {
        enemiesCountControl = enemiesCount;
        timerControl = timerHordeControl;
         CGC = FindAnyObjectByType<CopasGunsControler>();
    }

    void FixedUpdate()
    {
        if(numeroHorda == 12){
        winGameTimer -= Time.deltaTime;
        }

    }

    
    void Update()
    {

        if(winGameTimer <= 0)
        {
            
            SceneManager.LoadScene(3);

        }

        if(Input.GetMouseButtonDown(0))
        {
            HordeAudio.PlayOneShot(click);
        }
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

        if(distancia >= 249 & distancia <= 250){

            horda5();

        }

        if(distancia >= 299 & distancia <= 300){

            horda6();

        }

        if(distancia >= 349 & distancia <= 350){

            horda7();

        }

        if(distancia >= 399 & distancia <= 400){

            horda8();

        }

        if(distancia >= 449 & distancia <= 450){

            horda9();

        }

        if(distancia >= 499 & distancia <= 500){

            horda10();

        }

        if(distancia >= 549 & distancia <= 550){

            horda11();

        }

        if(distancia >= 599 & distancia <= 600){

            horda12();

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
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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
            radioAudio.PlayOneShot(allCleared);

        }

    }

    private void horda2(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda3(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda4(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(bigOne);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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
            radioAudio.PlayOneShot(allCleared);
            CGC.maxArmaLiberada = 1;

        }
    }

    private void horda5(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

         if(kills == 8){

            timerControl = 2;
            kills = 0;
            distancia = 251;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda6(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

         if(kills == 9){

            timerControl = 1;
            kills = 0;
            distancia = 301;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda7(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

         if(kills == 10){

            timerControl = 1;
            kills = 0;
            distancia = 351;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda8(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(bigOne);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

            Instantiate(ass, transform.position, transform.rotation);

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

            timerControl = 1;
            kills = 0;
            distancia = 401;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);
             CGC.maxArmaLiberada = 2;

        }
    }

    private void horda9(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

         if(kills == 12){

            timerControl = 0.5f;
            kills = 0;
            distancia = 451;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda10(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

         if(kills == 13){

            timerControl = 0.5f;
            kills = 0;
            distancia = 501;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda11(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

         if(kills == 14){

            timerControl = 0.5f;
            kills = 0;
            distancia = 551;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);

        }
    }

    private void horda12(){

        if(!HordaEstaEmAndamento){
        HordaEstaEmAndamento = true;
        radioAudio.PlayOneShot(enemyInComming);

        if (numeroHorda == 4 || numeroHorda == 8)
        {
            enemiesCountControl = 1;
        }
        else if (numeroHorda == 12)
        {
            enemiesCountControl = 500000; // ou o número que tu quiser
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

        Instantiate(drones, new Vector3(Random.Range(-8f, 8f), transform.position.y, transform.position.z), transform.rotation);

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

         if(kills == 500000){

            timerControl = 0.5f;
            kills = 0;
            distancia = 601;
            HordaEstaEmAndamento = false;
            numeroHorda++;
            radioAudio.PlayOneShot(allCleared);

        }
    }
}
