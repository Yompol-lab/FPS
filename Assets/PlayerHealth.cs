using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f; // Vida máxima del jugador
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth; // Inicializar la vida
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // Reducir la vida
        Debug.Log("Vida actual del jugador: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("El jugador ha muerto.");
        // Aquí puedes reiniciar la escena, mostrar una pantalla de Game Over, etc.
    }

    public float GetCurrentHealth()
    {
        return currentHealth; // Permitir que otros scripts accedan a la vida actual
    }
}
