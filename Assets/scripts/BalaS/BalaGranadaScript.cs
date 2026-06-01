using UnityEngine;

public class BalaGranadaScript : MonoBehaviour
{

    private float tempoDeTela = 0;
    public GameObject explosion;

    public AudioSource granada;
    public AudioClip explosionSound;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        transform.position += transform.up * 10f * Time.deltaTime;

        tempoDeTela++;

        if(tempoDeTela == 35){

            Instantiate(explosion, transform.position, transform.rotation);
             granada.PlayOneShot(explosionSound);
            Destroy(gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.CompareTag("tankDanoBox")){
            
            Debug.Log("acertei");
            Instantiate(explosion, transform.position, transform.rotation);
            granada.PlayOneShot(explosionSound);
            Destroy(gameObject);

        }

    }
}
