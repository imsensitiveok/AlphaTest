using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject[] snake;
    public int numSnakes;
    public string scene;

    private void Update()
    {
        float minDist = 4;
        float dist;
        bool isHidden = (bool)Variables.ActiveScene.Get("IsHidden");
        if (isHidden == false)
        {
            for (int i = 0; i < numSnakes; i++)
            {
                dist = Vector3.Distance(snake[i].transform.position, transform.position);       //calculates distance between the snake and the chameleon
                if (dist < minDist)                                                             //checks if the snake is within game over range of the chameloen
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
}
