using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource buttonClick;
    public AudioClip tokenCollect;
    public AudioClip snakeBite;

    public void PlayToken()
    {
        //tokenCollect.Play();
    }

    public void PlayClick()
    {
        buttonClick.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        //tokenCollect.Play();
        if(other.tag == "RedChip")
        {
            AudioSource.PlayClipAtPoint(tokenCollect, transform.position);
        }
         if(other.tag == "BlueChip")
        {
            AudioSource.PlayClipAtPoint(tokenCollect, transform.position);
        }
         if (other.tag == "GreenChip")
        {
            AudioSource.PlayClipAtPoint(tokenCollect, transform.position);
        }

        if (other.tag == "collectable")
        {
            AudioSource.PlayClipAtPoint(tokenCollect, transform.position);
        }

        if (other.tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(snakeBite, transform.position);
        }

    }

}
