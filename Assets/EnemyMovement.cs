using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; // Objetivo (el jugador)
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Mover al enemigo hacia el jugador
        agent.SetDestination(player.position);

        // Si el enemigo tiene velocidad, rota hacia la dirección del movimiento
        if (agent.velocity.sqrMagnitude > 0.01f) // Comprobamos si está en movimiento
        {
            Vector3 direction = agent.velocity.normalized; // Dirección del movimiento
            Quaternion lookRotation = Quaternion.LookRotation(direction); // Rotación hacia la dirección
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f); // Rotación suave
        }
    }
}
