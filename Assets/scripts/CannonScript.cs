using UnityEngine;

public class CannonScript : MonoBehaviour
{

    public GameObject bala;
    public GameObject balaExitPoint;
    
    void Start()
    {
        
    }

    void Update(){

        if(Input.GetKeyDown(KeyCode.UpArrow)){

           Instantiate(bala, balaExitPoint.transform.position, transform.rotation);

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
