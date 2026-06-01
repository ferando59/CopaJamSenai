using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BaseScript : MonoBehaviour
{

    public Slider barraVida;
    private float vida = 1000;
    private float vidaAtual;
    private bool DanoDeBala;
    private bool DanoDeBalaSniper;
    private bool DanoDeExplosion;

    private bool DanoDeBalaMiniGun;

    public AudioSource baseAudio;
    public AudioClip dano;
  
  
    void Start()
    {
        vidaAtual = vida;

        barraVida.maxValue = vida;
        barraVida.value = vidaAtual;
    }

    
    void Update()
    {
        TomarDanoDeBala();
        TomarDanoDeBalaSniper();
        TomarDanoDeExplosion();
        TomarDanoDeMiniGun();

    if(vidaAtual <= 0)
        {
            
             SceneManager.LoadScene(2);

        }

    }

    private void OnTriggerEnter2D(Collider2D other){
        
        if(other.CompareTag("EneBala")){

           
            DanoDeBala = true;
            baseAudio.PlayOneShot(dano);

        }

        if(other.CompareTag("EneBalaSniper")){

           
            DanoDeBalaSniper = true;
            baseAudio.PlayOneShot(dano);

        }

        if(other.CompareTag("eneExplosion")){

           
            DanoDeExplosion = true;
            baseAudio.PlayOneShot(dano);

        }

        if(other.CompareTag("EneBalaMiniGun")){

           
            DanoDeBalaMiniGun = true;
            baseAudio.PlayOneShot(dano);

        }


    }

    void TomarDanoDeBala(){

        if(DanoDeBala == true){
            
           
            vidaAtual -= 1;
            DanoDeBala = false;
            barraVida.value = vidaAtual;
            
        }
        
    }

    void TomarDanoDeBalaSniper(){

        if(DanoDeBalaSniper == true){
            
           
            vidaAtual -= 5;
            DanoDeBalaSniper = false;
            barraVida.value = vidaAtual;
            
        }
        
    }

     void TomarDanoDeExplosion(){

        if(DanoDeExplosion == true){
            
           
            vidaAtual -= 10;
            DanoDeExplosion = false;
            barraVida.value = vidaAtual;
            
        }
        
    }

    void TomarDanoDeMiniGun(){

        if(DanoDeBalaMiniGun == true){
            
           
            vidaAtual -= 10;
            DanoDeBalaMiniGun = false;
            barraVida.value = vidaAtual;
            
        }
        
    }
}
