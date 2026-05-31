using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SoundMaker : MonoBehaviour
{
    
public AudioSource soundMaker;
public AudioClip click;

public TMP_Text seusPontos;


    void Start()
    {
        seusPontos.text = "your score: "+PointCounterScript.instance.points;
    }

   
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
