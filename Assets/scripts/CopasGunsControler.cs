using UnityEngine;

public class CopasGunsControler : MonoBehaviour
{
   public GameObject[] copasGuns;
   private int armaAtual = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            armaAtual++;
            if(armaAtual >= copasGuns.Length)
            armaAtual = 0;
            TrocarArma(armaAtual);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            armaAtual--;
            if(armaAtual < 0)
            armaAtual = copasGuns.Length -1;
            TrocarArma(armaAtual);
        }
    }

     void TrocarArma(int numero)
    {
        for (int i = 0; i < copasGuns.Length; i++)
        {
            copasGuns[i].SetActive(false);
        }

        copasGuns[numero].SetActive(true);
        armaAtual = numero;
    }
}
