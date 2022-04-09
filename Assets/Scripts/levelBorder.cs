using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBorder : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnTriggerEnter(Collider other)
    {
        gameOverScreen.SetActive(true);
    }
}
