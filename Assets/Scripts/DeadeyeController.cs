using UnityEngine;

public class DeadeyeController : MonoBehaviour
{
    public Camera playerCamera; // Referencia a la c�mara del jugador
    public float deadeyeDuration = 3f; // Duraci�n del deadeye
    public float deadeyeFOV = 30f; // Campo de visi�n al activar el deadeye
    private float normalFOV; // Campo de visi�n normal
    private bool isDeadeyeActive = false; // Estado del deadeye
    private float deadeyeTimer = 0f; // Temporizador para la duraci�n del deadeye

    void Start()
    {
        normalFOV = playerCamera.fieldOfView; // Guardar el FOV normal
    }

    void Update()
    {
        // Activar el deadeye al presionar la tecla "Shift"
        if (Input.GetKeyDown(KeyCode.LeftShift) && !isDeadeyeActive)
        {
            ActivateDeadeye();
        }

        // Desactivar el deadeye si est� activo
        if (isDeadeyeActive)
        {
            deadeyeTimer += Time.deltaTime;
            if (deadeyeTimer >= deadeyeDuration)
            {
                DeactivateDeadeye();
            }
        }
    }

    void ActivateDeadeye()
    {
        isDeadeyeActive = true;
        deadeyeTimer = 0f; // Reiniciar el temporizador
        playerCamera.fieldOfView = deadeyeFOV; // Cambiar el campo de visi�n
        // Aqu� puedes agregar efectos visuales o de sonido si lo deseas
    }

    void DeactivateDeadeye()
    {
        isDeadeyeActive = false;
        playerCamera.fieldOfView = normalFOV; // Volver al campo de visi�n normal
        // Aqu� puedes restablecer efectos visuales o de sonido si lo deseas
    }
}
