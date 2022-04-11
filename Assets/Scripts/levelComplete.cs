using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public GameObject bridge;
    public GameObject bridgePrompt;
    public int goal;

    public AudioSource FoundAll;

    bool complete = false;

    private void Update()
    {
        int ObjNum = (int)Variables.ActiveScene.Get("ObjNum");
        if (goal == ObjNum)
        {
            Debug.Log("Goal Reached");
            complete = true;
            //AudioListener.pause = true;
            FoundAll.Play();
            //AudioListener.pause = false;

            bridge.SetActive(true);
            bridgePrompt.SetActive(true);
            
        }

        /*if (complete)
        {
            AudioListener.pause = true;
            FoundAll.Play();
            AudioListener.pause = false;
            complete = false;
            Destroy(FoundAll);
            
        }*/

    }
}
