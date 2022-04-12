using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject winScreen;
    public GameObject[] snake;
    public int numSnakes;
    public string scene;
    private float dist;


    private void Update()
    {
        bool isHidden = (bool)Variables.ActiveScene.Get("IsHidden");
        if (isHidden == false)                                                  //checks if player has won the game or is hidding
        {
            for (int i = 0; i < numSnakes; i++)
            {
                dist = Vector3.Distance(snake[i].transform.position, transform.position);       //calculates distance between the snake and the chameleon
                if (dist < 4 && !winScreen.activeSelf)                                          //checks if the snake is within game over range of the chameloen
                {
                    gameOverScreen.SetActive(true);                                             //activates game over screen
                }
            }
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(scene);
    }

    public void mainMenuButton()
    {
        SceneManager.LoadScene("landingPage"); 
    }
}
