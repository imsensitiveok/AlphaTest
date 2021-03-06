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

    //public AudioSource FoundAll;
    public AudioClip FoundAll;

    bool complete;

    private void Start()
    {
        complete = false;
    }

    private void Update()
    {
        int ObjNum = (int)Variables.ActiveScene.Get("ObjNum");
        if (goal == ObjNum)
        {
            bridge.SetActive(true);
            bridgePrompt.SetActive(true);

        }

        if (goal == ObjNum && !complete)
        {
            AudioSource.PlayClipAtPoint(FoundAll, transform.position);
            complete = true;
        }

    }

}
