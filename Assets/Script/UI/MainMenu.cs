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
        Time.timeScale = 1;
    }

    public void Pause ()
    {
        GameIsPaused = true;
        Time.timeScale = 0;
    }

    public void SceneChanging()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackMainMenu(string sceneToGo)
    {
        SceneManager.LoadScene(sceneToGo);
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void OnTriggerEnter(Collider collision){
        print(collision);
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
