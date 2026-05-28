using UnityEngine;

public class BalaSniperScript : MonoBehaviour
{

    private float tempoDeTela = 0;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        transform.position += transform.up * 15f * Time.deltaTime;

        tempoDeTela++;

        if(tempoDeTela == 100){

            Destroy(gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("tankDanoBox")){

            //Debug.Log("acertei");
            Destroy(gameObject);

        }

    }
}