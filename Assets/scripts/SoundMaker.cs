using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundMaker : MonoBehaviour
{
    
public AudioSource soundMaker;
public AudioClip click;


    void Start()
    {
        DontDestroyOnLoad(gameObject);
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

    
}
