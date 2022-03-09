using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attractObject : MonoBehaviour
{

    gravitationalPull planetGravPull;
    public Rigidbody planetRigidbody; 

    // Start is called before the first frame update
    void Start()
    {
        planetGravPull = GameObject.FindGameObjectWithTag("Planet").GetComponent<gravitationalPull>();
        planetRigidbody.useGravity = false;
        planetRigidbody.constraints = RigidbodyConstraints.FreezeRotation; 
    }

    void FixedUpdate()
    {
        planetGravPull.Attract(transform); 
    }
}
