using UnityEngine;

public class BalaCopaHeartScript : MonoBehaviour
{

    private float tempoDeTela = 0;
    public GameObject explosion;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        transform.position += transform.up * 10f * Time.deltaTime;

        tempoDeTela++;

        if(tempoDeTela == 35){

            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("enemy")){

            Debug.Log("acertei");
             Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);

        }

    }
}
