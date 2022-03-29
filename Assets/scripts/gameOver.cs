using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject snake;
    public string scene;

    private void Update()
    {
        float minDist = 2;
        float dist = Vector3.Distance(snake.transform.position, transform.position);
        bool isHidden = (bool)Variables.ActiveScene.Get("IsHidden");
        if (dist < minDist && isHidden == false)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(scene);
    }
}
