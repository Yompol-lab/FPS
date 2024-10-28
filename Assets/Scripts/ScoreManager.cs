using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; 
    public Text victoryText; 
    private int score = 0; 
    private int victoryScore = 520; 

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
        scoreText.text = "Puntaje: " + score;
    }

   
    void CheckVictory()
    {
        if (score >= victoryScore) 
        {
            ShowVictoryMessage(); 
        }
    }

   
    void ShowVictoryMessage()
    {
        victoryText.gameObject.SetActive(true); 
        victoryText.text = "¡Victoria! Puntaje Final: " + score;
    }
}
