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
    public int levelNum; 


    private void Update()
    {
        int ObjNum = (int)Variables.ActiveScene.Get("ObjNum");
        if (goal == ObjNum)
        {
            winScreen.SetActive(true);
            PlayerPrefs.SetInt("highestLevel", levelNum + 1);
            Debug.Log(PlayerPrefs.GetInt("highestLevel")); 
        }
    }

    public void nextLevelButton()
    {
        SceneManager.LoadScene(nextScene);
    }
}
