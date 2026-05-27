using UnityEngine;

public class BalaScript : MonoBehaviour
{

    private float tempoDeTela = 0;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        transform.position += transform.up * 10f * Time.deltaTime;

        tempoDeTela++;

        if(tempoDeTela == 100){

            Destroy(gameObject);

        }

    }

    void OnTriggerEnter(Collider other){

        if(other.CompareTag("enemy")){

            Destroy(gameObject);

        }

    }
}
