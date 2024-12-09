using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreenController : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MenuFPS"); // Reemplaza con el nombre exacto de tu escena de menú principal
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("El juego se ha cerrado."); // Solo para pruebas en el editor
    }
}
