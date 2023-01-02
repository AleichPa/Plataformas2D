using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject PauseMenus;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseButton();
        }
       
        if (Input.GetKey(KeyCode.P))
        {
            PlayButton();
        }

        if (Input.GetKey(KeyCode.R))
        {
            RestartButton();
        }
       
        if (Input.GetKey(KeyCode.M))
        {
            ReturnMenu();
        }

        if (Input.GetKey(KeyCode.E))
        {
            QuitGame();
        }
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PauseButton()
    {
        PauseMenus.SetActive(true);
        Time.timeScale = 0;
    }
    public void PlayButton()
    {
        PauseMenus.SetActive(false);
        Time.timeScale = 1;
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Debug.Log("Cerrando Juego");
        Application.Quit();
    }

}
