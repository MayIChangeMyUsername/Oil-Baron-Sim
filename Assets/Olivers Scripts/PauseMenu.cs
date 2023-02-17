using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Allr i detta script utom mainCanvas delarna är gjorda av Oliver, main canvas delarn är av Elliot

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject mainCanvas; //Elliot

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
        mainCanvas.SetActive(true); //startar spelet efter paus - Elliot

    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true); //pausar spelet -Oliver
        Time.timeScale = 0f;
        GameIsPaused = true;
        mainCanvas.SetActive(false); //pausar spelet - Elliot
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
