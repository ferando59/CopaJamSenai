using UnityEngine;

public class quaEspadasScript : MonoBehaviour
{
    private int estado;
    private float tempoEstado;

    public GameObject balaExitPointDoisOuro;
    public GameObject bala;

    private bool DanoDeBala;

     private bool DanoDeExplosion;

    private int vida = 5;

    //public GameObject horda;
    PointCounterScript PC;
    HordesScript HS;

    private bool distanciaDoInimigoEstaCerta = false;
    private int distanciaDoInimigo = 0;

    public AudioSource doisOuroAudio;
    public AudioClip tiro;
    public AudioClip ouch;
    public Animator anim;


    void Start()
    {
       PC = FindAnyObjectByType<PointCounterScript>();
       HS = FindAnyObjectByType<HordesScript>();
       anim = GetComponent<Animator>();
    }

    void EscolherEstado(){

        estado = Random.Range(0, 7);

        if(estado == 6) tempoEstado = Random.Range(0.1f,0.5f);
        if(estado >= 3 && estado <= 5) tempoEstado = Random.Range(1f,5f);
        if(estado >= 0 && estado <= 2) tempoEstado = 0.00001f;
    }

   
    void Update()
    {

        if(distanciaDoInimigoEstaCerta == false){
            
            transform.position += transform.up * -4f * Time.deltaTime;
            distanciaDoInimigo++;

        }

        if(distanciaDoInimigo == 50){
            
            distanciaDoInimigoEstaCerta = true;

        }

        TomarDanoDeBala();
        TomarDanoDeExplosion();
        Morrer();

        tempoEstado -= Time.deltaTime;

        if(tempoEstado <= 0)
          EscolherEstado();

        if(estado == 6){

            andar();
            anim.SetBool("shoting", false);
            anim.SetBool("iswalking", true);
            anim.SetBool("stoped", false);


        } 



        if(estado >= 3 && estado <= 5){

             parar();
             anim.SetBool("shoting", false);
            anim.SetBool("iswalking", false);
            anim.SetBool("stoped", true);


        }
        

        if(estado >= 0 && estado <= 2){ 

            atirar();
            Debug.Log("era pra atirar bro");
            anim.SetBool("shoting", true);
            anim.SetBool("iswalking", false);
            anim.SetBool("stoped", false);
        }
        
    }

    void andar(){

        transform.position += transform.up * -1f * Time.deltaTime;

    }

    void parar(){



    }

    void atirar(){

        Instantiate(bala, balaExitPointDoisOuro.transform.position, transform.rotation * Quaternion.Euler(0, 0, 180));
        doisOuroAudio.PlayOneShot(tiro);

    }

    private void OnTriggerEnter2D(Collider2D other){
        
        if(other.CompareTag("bala") || other.CompareTag("Radio")){

           
            DanoDeBala = true;
            doisOuroAudio.PlayOneShot(ouch);

        }

        if(other.CompareTag("explosion")){

           
            DanoDeExplosion = true;

        }

    }

    void TomarDanoDeBala(){

        if(DanoDeBala == true){
            
            Debug.Log("era pra ter tomado dano");
            vida -= 1;
            DanoDeBala = false;
            
        }
        
    }

    void TomarDanoDeExplosion(){

        if(DanoDeExplosion == true){
            
           
            vida -= 5;
            DanoDeExplosion = false;
            
        }
        
    }

    void Morrer(){
        
        if(vida <= 0){

           
            HS.kills+=1;
            PC.points+=400;
            Destroy(gameObject);

        }

    }
}
