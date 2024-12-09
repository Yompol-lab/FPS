using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("MenuFPS");

    }

    public void Salir()
    {
        Debug.Log("SALIR...");
        Application.Quit();


    }



}
