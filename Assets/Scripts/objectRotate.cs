using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotate : MonoBehaviour
{
    public float yRotate;
    public float xRotate;
    public float zRotate;

    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
