using UnityEngine;

public class CopasGranadas : MonoBehaviour
{
    private float intervaloTiros = 3;
    private float intervalo;

    public GameObject copasHearts;

   void OnEnable()
    {
        //intervaloTiros = intervalo;
        intervalo = intervaloTiros;
    }


   
    void Update()
    {
        intervaloTiros -= Time.deltaTime;
        jogarGranada();
    }

    void jogarGranada(){
    if(intervaloTiros <= 0){
        Instantiate(copasHearts, new Vector3(Random.Range(-7f, 7f), transform.position.y, transform.position.z), transform.rotation);
        }

        if(intervaloTiros <= 0){
            intervaloTiros = intervalo;
        }
    }
}
