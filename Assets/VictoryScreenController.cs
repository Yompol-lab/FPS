using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreenController : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MenuFPS"); 
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("El juego se ha cerrado."); // Solo para pruebas en el editor
    }
}
