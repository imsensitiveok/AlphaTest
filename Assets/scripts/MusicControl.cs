using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicControl : MonoBehaviour
{
    public static MusicControl instance;

    private void Awake()
    {

        

        DontDestroyOnLoad(this.gameObject);

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    private void Update()
    {
        
        if (SceneManager.GetActiveScene().name == "levelOne")
        {
            
            Destroy(gameObject);
        }

        if (SceneManager.GetActiveScene().name == "levelTwo")
        {
            
            Destroy(gameObject);
        }

    }
}
