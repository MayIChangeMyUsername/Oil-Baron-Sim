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
        if (Input.GetKeyDown(KeyCode.Escape)) //När man trycker "escape" så pausas spelet och öppnar PausMenu. -Oliver
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
       
        SceneManager.LoadScene("Olivers Scen"); //laddar "Olivers Scen" som innehåller MainMenu. -Oliver
    }
    public void QuitGame() 
    {
        Application.Quit(); //stänger spelet när man klickar på knappen med den funktionen. -Oliver
    }
}
