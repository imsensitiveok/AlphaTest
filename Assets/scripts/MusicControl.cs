using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicControl : MonoBehaviour
{
    public static MusicControl instance;

    bool muteOn = false;

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

        if (SceneManager.GetActiveScene().name == "levelThree")
        {

            Destroy(gameObject);
        }

        if (Input.GetKeyDown("m"))
        {
            Debug.Log("muted");
            muteOn = !muteOn;
            AudioListener.pause = muteOn;
        }

    }
}
