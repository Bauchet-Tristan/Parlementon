using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    //public GameObject pauseMenuUI;

    public void Resume ()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void Pause ()
    {
        GameIsPaused = true;
        Time.timeScale = 0f;
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }    

}
