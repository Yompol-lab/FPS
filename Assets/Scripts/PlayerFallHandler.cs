using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class PlayerFallHandler : MonoBehaviour
{
    public Text deathText;
    public float fallThreshold = -10f;
    public float restartDelay = 5f;

    void Start()
    {
        deathText.gameObject.SetActive(false);
    }

    void Update()
    {
        CheckFall();
    }


    void CheckFall()
    {
        if (transform.position.y < fallThreshold)
        {
            ShowDeathMessage();
        }
    }


    void ShowDeathMessage()
    {
        deathText.gameObject.SetActive(true);
        deathText.text = "¡Moriste!";
        Invoke("RestartScene", restartDelay);
    }


    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}