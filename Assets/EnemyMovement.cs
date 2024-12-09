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

        // Si el enemigo tiene velocidad, rota hacia la direcci�n del movimiento
        if (agent.velocity.sqrMagnitude > 0.01f) // Comprobamos si est� en movimiento
        {
            Vector3 direction = agent.velocity.normalized; // Direcci�n del movimiento
            Quaternion lookRotation = Quaternion.LookRotation(direction); // Rotaci�n hacia la direcci�n
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f); // Rotaci�n suave
        }
    }
}
