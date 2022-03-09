using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitationalPull : MonoBehaviour
{

    public float gravity = -9.8f; 

    //body = the chameleon, transform.position = transofrm the object the script is attatched to (the planet) 
    public void Attract(Transform body)
    {
        Vector3 targetDirection = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        body.rotation = Quaternion.FromToRotation(bodyUp, targetDirection) * body.rotation;
        body.GetComponent<Rigidbody>().AddForce(targetDirection * gravity); 
    }
/*
    private void FixedUpdate()
    {
        gravPull(); 
    }

    void gravPull()
    {
        Vector3 objDirection = mass1Rigidbody.position - mass2Rigidbody.position;
        float distanceBtwObj = objDirection.magnitude;
        float gravForce = (mass1Rigidbody.mass * mass2Rigidbody.mass) / Mathf.Pow(distanceBtwObj, 2) * -10;

        Vector3 force = objDirection.normalized * gravForce; 

        mass2Rigidbody.AddForce(force); 

    }*/
}
