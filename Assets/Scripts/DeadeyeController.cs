using UnityEngine;

public class DeadeyeController : MonoBehaviour
{
    public Camera playerCamera; // Referencia a la cámara del jugador
    public float deadeyeDuration = 3f; // Duración del deadeye
    public float deadeyeFOV = 30f; // Campo de visión al activar el deadeye
    private float normalFOV; // Campo de visión normal
    private bool isDeadeyeActive = false; // Estado del deadeye
    private float deadeyeTimer = 0f; // Temporizador para la duración del deadeye

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

        // Desactivar el deadeye si está activo
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
        playerCamera.fieldOfView = deadeyeFOV; // Cambiar el campo de visión
        // Aquí puedes agregar efectos visuales o de sonido si lo deseas
    }

    void DeactivateDeadeye()
    {
        isDeadeyeActive = false;
        playerCamera.fieldOfView = normalFOV; // Volver al campo de visión normal
        // Aquí puedes restablecer efectos visuales o de sonido si lo deseas
    }
}
