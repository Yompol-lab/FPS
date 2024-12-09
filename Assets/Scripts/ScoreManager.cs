using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text victoryText;
    private int score = 0;
    private int victoryScore = 50;

    void Start()
    {
        UpdateScoreText();
        victoryText.gameObject.SetActive(false);
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
        CheckVictory();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Kills: " + score;
    }


    void CheckVictory()
    {
        if (score >= victoryScore)
        {
            // Mostrar mensaje de victoria
            victoryText.gameObject.SetActive(true);

            // Destruir al personaje
            GameObject player = GameObject.FindWithTag("Player"); // Asegúrate de que tu jugador tenga el tag "Player"
            if (player != null)
            {
                Destroy(player);
            }

            // Desbloquear el cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


            if (score >= victoryScore)
            {
                SceneManager.LoadScene("Ganaste");
            }
        }

    
    }
}
