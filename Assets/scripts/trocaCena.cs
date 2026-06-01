using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class trocaCena : MonoBehaviour
{
    
public AudioSource soundMaker;
public AudioClip click;
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            soundMaker.PlayOneShot(click);
        }
    }

    public void irProJogo()
    {
        
        SceneManager.LoadScene(1);
        
    }

     public void irMenu()
    {
        
        SceneManager.LoadScene(0);
        
    }

    
}
