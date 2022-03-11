using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject snake;

    private void Update()
    {
        float minDist = 1;
        float dist = Vector3.Distance(snake.transform.position, transform.position);
        if (dist < minDist)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("AlphaTest");
    }
}
