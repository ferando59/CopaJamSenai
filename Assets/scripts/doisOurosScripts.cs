using UnityEngine;

public class doisOurosScripts : MonoBehaviour
{
    private int estado;
    private float tempoEstado;

    public GameObject balaExitPointDoisOuro;
    public GameObject bala;

    private bool DanoDeBala;

    private int vida = 3;

    //public GameObject horda;
    HordesScript HS;

    private bool distanciaDoInimigoEstaCerta = false;
    private int distanciaDoInimigo = 0;


    void Start()
    {
       HS = FindAnyObjectByType<HordesScript>();
    }

    void EscolherEstado(){

        estado = Random.Range(0, 7);

        if(estado >= 0 && estado <= 2) tempoEstado = Random.Range(0.1f,0.5f);
        if(estado >= 3 && estado <= 5) tempoEstado = Random.Range(1f,5f);
        if(estado == 6) tempoEstado = 0.00001f;
    }

   
    void Update()
    {
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
            Debug.Log("era pra atirar bro");
        }
        
    }

    void andar(){

        transform.position += transform.up * -1f * Time.deltaTime;

    }

    void parar(){



    }

    void atirar(){

        Instantiate(bala, balaExitPointDoisOuro.transform.position, transform.rotation * Quaternion.Euler(0, 0, 180));

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
            HS.points+=200;
            Destroy(gameObject);

        }

    }
}
