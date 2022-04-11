using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource buttonClick;
    public AudioSource tokenCollect;

    public void PlayClick()
    {
        buttonClick.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        tokenCollect.Play();
    }

}
