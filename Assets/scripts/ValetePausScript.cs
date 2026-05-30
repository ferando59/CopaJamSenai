using UnityEngine;

public class ValetePausScript : MonoBehaviour
{
    private int estado;
    private float tempoEstado;

    public GameObject balaExitPointDoisOuro;
    public GameObject balaExitPointMiniGun1;
    public GameObject balaExitPointMiniGun2;
    public GameObject bala;
    public GameObject granandaBala;

    private bool DanoDeBala;

    private int vida = 50;

    //public GameObject horda;
    HordesScript HS;

    private bool distanciaDoInimigoEstaCerta = false;
    private int distanciaDoInimigo = 0;

    private int disHorizontal = 0;

    public float intervaloTiros = 1;
    private float intervalo;

    public AudioSource valeteAudio;
    public AudioClip miniGun;

    private int podeTocar;


    void Start()
    {
       HS = FindAnyObjectByType<HordesScript>();
       intervalo = intervaloTiros;
    }

    void EscolherEstado(){

        estado = Random.Range(0, 8);

        if(estado >= 0 && estado <= 2) tempoEstado = Random.Range(0.5f,5f);
        if(estado >= 3 && estado <= 5) tempoEstado = Random.Range(0.5f,5f);
        if(estado == 6) tempoEstado = 1.5f;
        if(estado == 7) tempoEstado = 0.000001f;

        podeTocar = estado;
    }

   
    void Update()
    {

        if(podeTocar == 6)
        {
            podeTocar = 0;
            valeteAudio.PlayOneShot(miniGun);

        }

        intervaloTiros -= Time.deltaTime;

        if(distanciaDoInimigoEstaCerta == false){
            
            transform.position += transform.up * -4f * Time.deltaTime;
            distanciaDoInimigo++;

        }

        if(distanciaDoInimigo == 100){
            
            distanciaDoInimigoEstaCerta = true;

        }

        TomarDanoDeBala();
        Morrer();

        tempoEstado -= Time.deltaTime;

        if(tempoEstado <= 0)
          EscolherEstado();

        if(estado >= 0 && estado <= 2) andar();
        if(estado >= 3 && estado <= 5) parar();
        if(estado == 6){ 

            atirar();
            //Debug.Log("era pra atirar bro");
        }
        if(estado == 7) granada();
        
    }

    void andar(){

        if(disHorizontal < 400){
        transform.position += transform.right * -3f * Time.deltaTime;
        disHorizontal++;
        }

    }

    void parar(){
        
        if(disHorizontal > -400){
        transform.position += transform.right * 3f * Time.deltaTime;
        disHorizontal--;
        }

    }

    void atirar(){

        if(intervaloTiros <= 0){
        Instantiate(bala, balaExitPointMiniGun1.transform.position, transform.rotation * Quaternion.Euler(0, 0, 180));
        Instantiate(bala, balaExitPointMiniGun2.transform.position, transform.rotation * Quaternion.Euler(0, 0, 180));
        }

        if(intervaloTiros <= 0){
            intervaloTiros = intervalo;
        }

    }

    void granada(){

        Instantiate(granandaBala, balaExitPointDoisOuro.transform.position, transform.rotation * Quaternion.Euler(0, 0, 180));

    }

    private void OnTriggerEnter2D(Collider2D other){
        
        if(other.CompareTag("bala") || other.CompareTag("Radio")){

           
            DanoDeBala = true;

        }

    }

    void TomarDanoDeBala(){

        if(DanoDeBala == true){
            
            Debug.Log("era pra ter tomado dano");
            vida -= 1;
            DanoDeBala = false;
            
        }
        
    }

    void Morrer(){
        
        if(vida <= 0){

           
            HS.kills+=1;
            HS.points+=10000;
            Destroy(gameObject);

        }

    }
}
