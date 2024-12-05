using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyNavigation : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform player;
    public float initialDelay;
    public float interval;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player= GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("SetDestination", initialDelay, interval);

    }

    public void SetDestination()
    {
        Debug.Log("Set destination" + player.position);
        agent.destination = player.position;

    }
}
