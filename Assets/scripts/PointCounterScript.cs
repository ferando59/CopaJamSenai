using UnityEngine;

public class PointCounterScript : MonoBehaviour
{

    public static PointCounterScript instance;

    public int points = 0;
   
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

   
    void Update()
    {
        
    }
}
