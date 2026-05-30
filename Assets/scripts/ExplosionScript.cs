using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
   private float vida = 1;

    void Start()
    {
        
    }

    
    void Update()
    {
        vida -= Time.deltaTime;

        if(vida <= 0)
        {
            
            Destroy(gameObject);

        }
    }
}
