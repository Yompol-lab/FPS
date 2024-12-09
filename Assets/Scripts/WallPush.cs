using UnityEngine;

public class WallPush : MonoBehaviour
{
    public float moveSpeed = 2f; // Velocidad de movimiento de las paredes
    public float pushForce = 5f; // Fuerza con la que empuja al jugador
    public Transform startPosition; // Posici�n inicial de la pared
    public Transform endPosition; // Posici�n final de la pared
    private bool movingToEnd = true; // Direcci�n del movimiento

    void Update()
    {
        // Movimiento de la pared entre dos posiciones
        if (movingToEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endPosition.position) < 0.1f)
            {
                movingToEnd = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, startPosition.position) < 0.1f)
            {
                movingToEnd = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Empujar al jugador al colisionar
            Vector3 pushDirection = transform.forward; // Direcci�n de empuje
            collision.gameObject.GetComponent<Rigidbody>().AddForce(pushDirection * pushForce, ForceMode.Impulse);
        }
    }
}
