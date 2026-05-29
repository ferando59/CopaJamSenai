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

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("enemy")){

            Debug.Log("acertei");
            Destroy(gameObject);

        }

    }
}
