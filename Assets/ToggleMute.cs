using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMute : MonoBehaviour
{
    bool muteOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            Debug.Log("muted");
            muteOn = !muteOn;
            AudioListener.pause = muteOn;
        }
    }
}
