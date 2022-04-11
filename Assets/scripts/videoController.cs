using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video; 

public class videoController : MonoBehaviour
{

    public VideoPlayer cutScene;
    public string nextSceneName;
    public float videoLength; 
    
    // Start is called before the first frame update
    void Start()
    {
        cutScene = GetComponent<VideoPlayer>();
        cutScene.Play();
        StartCoroutine(waitVideoFinish()); 
    }

    IEnumerator waitVideoFinish()
    {
        bool videoFinished = false; 
        while(videoFinished == false)
        {
            yield return new WaitForSeconds(videoLength);
            videoFinished = true; 
            
        }
        SceneManager.LoadScene(nextSceneName);
    }
}
