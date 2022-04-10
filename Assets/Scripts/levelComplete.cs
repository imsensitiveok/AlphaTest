using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public GameObject bridge;
    public int goal;

    private void Update()
    {
        int ObjNum = (int)Variables.ActiveScene.Get("ObjNum");
        if (goal == ObjNum)
        {
            bridge.SetActive(true);
            //do the arrow thing
        }
    }
}
