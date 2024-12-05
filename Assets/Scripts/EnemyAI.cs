using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float attackDistance = 2f; // Distancia mínima para atacar
    public float damage = 10f; // Daño que inflige el enemigo
    public float attackCooldown = 2f; // Tiempo entre ataques

    private NavMeshAgent agent;
    private float attackTimer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        attackTimer = 0f;
    }

    void Update()
    {
        if (player == null) return;

        // Mover hacia el jugador
        agent.SetDestination(player.position);

        // Calcular la distancia al jugador
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Atacar si está en rango
        if (distanceToPlayer <= attackDistance)
        {
            agent.isStopped = true; // Detener el movimiento
            AttackPlayer();
        }
        else
        {
            agent.isStopped = false; // Permitir movimiento
        }

        // Actualizar el temporizador de ataque
        attackTimer += Time.deltaTime;
    }

    void AttackPlayer()
    {
        if (attackTimer >= attackCooldown)
        {
            // Aquí puedes integrar lógica para reducir la salud del jugador
            Debug.Log("Atacando al jugador! Daño: " + damage);
            attackTimer = 0f; // Reiniciar el temporizador
        }
    }
}
