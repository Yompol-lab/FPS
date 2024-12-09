using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class PlayerFallHandler : MonoBehaviour
{
    public Text deathText;
    public float fallThreshold = -10f;
    

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

       
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

      
        Destroy(gameObject);

        
       
        SceneManager.LoadScene("Moriste");

    }


   
}