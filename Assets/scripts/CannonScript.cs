using UnityEngine;

public class CannonScript : MonoBehaviour
{

    public GameObject bala;
    public GameObject balaExitPoint;

    public AudioSource cannonAudio;
    public AudioClip shot;
    
    void Start()
    {
        
    }

    void Update(){

        if(Input.GetKeyDown(KeyCode.UpArrow)){

           Instantiate(bala, balaExitPoint.transform.position, transform.rotation);
           cannonAudio.PlayOneShot(shot);

        }

    }

   
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.LeftArrow)){

            transform.Rotate(0,0,1);

        }

        if(Input.GetKey(KeyCode.RightArrow)){

            transform.Rotate(0,0,-1);

        }

        

    }
}
