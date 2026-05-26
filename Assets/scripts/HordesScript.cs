using UnityEngine;

public class HordesScript : MonoBehaviour
{

    public GameObject player;

    private bool HordaEstaEmAndamento = false;

    private float distancia = 0;

    private int kills = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Debug.Log("dis " + distancia);
        if(Input.GetKeyDown(KeyCode.K)){

                kills += 1;

            }


        if(distancia >= 49 & distancia <= 50){

            horda1();

        }

        if(distancia >= 99 & distancia <= 100){

            horda2();

        }

         andar(HordaEstaEmAndamento);
    }

    private void andar(bool NaoPode = false){

        if(!NaoPode){

            if(Input.GetKey(KeyCode.W)){

                player.transform.position += new Vector3(0f,0.1f,0f);
                distancia += 10 * Time.deltaTime;

            }

            /*
            if(Input.GetKey(KeyCode.S)){

                player.transform.position += new Vector3(0f,-0.1f,0f);
                distancia -= 10 * Time.deltaTime;

            }
            */

            if(HordaEstaEmAndamento == true){

                NaoPode = true;

            }else{

                NaoPode = false;

            }

        }

    }

    private void horda1(){

       HordaEstaEmAndamento = true;

        if(kills == 1){

            distancia = 51;
            HordaEstaEmAndamento = false;

        }

    }

    private void horda2(){

        HordaEstaEmAndamento = true;

         if(kills == 2){

             distancia = 101;
             HordaEstaEmAndamento = false;

        }
    }
}
