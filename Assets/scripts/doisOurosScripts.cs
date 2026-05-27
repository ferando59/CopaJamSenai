using UnityEngine;

public class doisOurosScripts : MonoBehaviour
{
    private int estado;
    private float tempoEstado;

    public GameObject balaExitPointDoisOuro;
    public GameObject bala;


    void Start()
    {
        
    }

    void EscolherEstado(){

        estado = Random.Range(0, 3);

        if(estado == 0) tempoEstado = Random.Range(0.1f,0.5f);
        if(estado == 1) tempoEstado = Random.Range(1f,5f);
        if(estado == 2) tempoEstado = Random.Range(0.1f,0.3f);

    }

   
    void Update()
    {

        tempoEstado -= Time.deltaTime;

        if(tempoEstado <= 0)
          EscolherEstado();
        
    }

    void andar(){

        transform.position += transform.up * 1f * Time.deltaTime;

    }

    void parar(){



    }

    void atirar(){

        Instantiate(bala, balaExitPointDoisOuro.transform.position, transform.rotation * Quaternion.Euler(0, 0, 180));

    }
}
