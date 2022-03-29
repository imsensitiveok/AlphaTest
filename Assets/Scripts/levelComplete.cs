using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    public GameObject winScreen;
    public int goal;
    public string nextScene;

    private void Update()
    {
        int ObjNum = (int)Variables.ActiveScene.Get("ObjNum");
        if (goal == ObjNum)
        {
            Time.timeScale = 0f;    //pauses game
            winScreen.SetActive(true);
        }
    }

    public void nextLevelButton()
    {
        SceneManager.LoadScene(nextScene);
    }
}
