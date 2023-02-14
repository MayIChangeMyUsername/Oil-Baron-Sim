using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //N�r man trycker "escape" s� pausas spelet och �ppnar PausMenu. -Oliver
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        
    }
    public void Resume ()
    {
        pauseMenuUI.SetActive(false); //startar spelet efter paus. -Oliver
        Time.timeScale = 1f;
            GameIsPaused = false;

    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true); //pausar spelet -Oliver
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
       
        SceneManager.LoadScene("Olivers Scen"); //laddar "Olivers Scen" som inneh�ller MainMenu. -Oliver
    }
    public void QuitGame() 
    {
        Application.Quit(); //st�nger spelet n�r man klickar p� knappen med den funktionen. -Oliver
    }
}
