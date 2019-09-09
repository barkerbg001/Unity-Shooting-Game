using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (UnityEngine.AI.NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent pathfinder;
    Transform target;

    void Start() {
        pathfinder = GetComponent<UnityEngine.AI.NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() {
        pathfinder.SetDestination(target.position);
    }
}
