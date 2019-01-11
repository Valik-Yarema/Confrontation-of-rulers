using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
   
    public Transform _target;

    private NavMeshAgent agent;
    void Start()
    {
        moving();
    }

    public void moving()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_target.position);
    }
}
