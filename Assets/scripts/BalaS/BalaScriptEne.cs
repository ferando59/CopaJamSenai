using UnityEngine;

public class BalaScriptEne : MonoBehaviour
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

        if(other.CompareTag("tankDanoBox")){

            //Debug.Log("acertei");
            Destroy(gameObject);

        }

    }
}
