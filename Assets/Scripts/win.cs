using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject winScreen;
    public string nextScene;
    public int levelNum;

    private void OnTriggerEnter(Collider other)
    {
        winScreen.SetActive(true);
        PlayerPrefs.SetInt("highestLevel", levelNum + 1);
        Debug.Log(PlayerPrefs.GetInt("highestLevel"));
    }

    public void nextLevelButton()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void mainMenuButton()
    {
        SceneManager.LoadScene("landingPage");
    }
}
