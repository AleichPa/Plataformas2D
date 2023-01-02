using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void EscenaTutorial()
    {
        SceneManager.LoadScene("Gimnasio");
    }

    public void Escena1() 
    {
        SceneManager.LoadScene("1");
    }

    public void Escena2()
    {
        SceneManager.LoadScene("2");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Debug.Log("Cerrando Juego");
        Application.Quit();
    }
}
