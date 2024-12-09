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
            SceneManager.LoadScene("Ganaste");
        }
    }

  
}
