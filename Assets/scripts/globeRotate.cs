using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globeRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0.05f, 0.02f); 
    }
}
