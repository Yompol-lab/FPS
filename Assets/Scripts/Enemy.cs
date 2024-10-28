using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int scoreValue = 10; 
    private ScoreManager scoreManager;

    void Start()
    {
        
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    
    public void EliminarEnemigo()
    {
        if (scoreManager != null)
        {
            scoreManager.AddScore(scoreValue); 
        }
        Destroy(gameObject); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) 
        {
            EliminarEnemigo(); 
        }
    }
}
