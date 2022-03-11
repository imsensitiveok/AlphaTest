using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using UnityEngine.AI;

public class Navigate : MonoBehaviour
{
    public Transform[] waypoints;

    public GameObject chameleon;

    enum SnakeState { Wander, Attack };
    SnakeState currentState = SnakeState.Wander;

    NavMeshAgent navMeshAgent;

    int currentWaypoint = 0;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
    }

    void Update()
    {
        switch(currentState)
        {
            case SnakeState.Wander:
                if(navMeshAgent.remainingDistance < 10)
                {
                    currentWaypoint = (currentWaypoint + 1)%5;
                    navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
                }

                break;
            case SnakeState.Attack:
                navMeshAgent.SetDestination(chameleon.transform.position);

                if ((bool)Variables.ActiveScene.Get("IsHidden"))
                {
                    navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
                    currentState = SnakeState.Wander;
                }


                break;
            default:
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ChangeState(SnakeState.Attack);
    }

    void ChangeState(SnakeState newState)
    {
        switch (currentState)
        {
            case SnakeState.Wander:
                navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
                break;
            case SnakeState.Attack:
                break;
            default:
                break;
        }
        currentState = newState;
    }
}
