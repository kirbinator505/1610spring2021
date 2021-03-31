﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentBehavior : MonoBehaviour
{
    public List<Transform> waypoints;


    private Transform destination;
    private NavMeshAgent agent;
    private int i;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = waypoints[i];
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    void Update()
    {
        agent.destination = destination.position;
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            i = (i + 1) % waypoints.Count;
            destination = waypoints[i];
        }
    }
}
