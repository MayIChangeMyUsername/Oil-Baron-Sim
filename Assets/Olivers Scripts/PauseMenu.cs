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
        //Time.timeScale = 1f; // Jag tog bort det är eftersom det gjorde så att knapp-animationerna inte fungerade, och det inte verkar göra någon skillnad annars - Elliot
            GameIsPaused = false;
        
        if (SceneManager.GetActiveScene().name == "Main Scen") //ser till att bara main canvas påverkas när man är i main scen - Elliot
        {
            mainCanvas.SetActive(true); //startar spelet efter paus - Elliot
            FindObjectOfType<SkipdayLockTest>().UpdateImageOnResume();
            //Debug.Log("UpdateImage");
        }


    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true); //pausar spelet -Oliver
       //Time.timeScale = 0f; //Jag tog bort det här eftersom det gjorde så att knapp-animationerna inte fungerade, och det inte verkar göra någon skillnad annars - Elliot  
        GameIsPaused = true;

        if(SceneManager.GetActiveScene().name == "Main Scen")  //ser till att bara main canvas påverkas när man är i main scen - Elliot
        {
            mainCanvas.SetActive(false); //pausar spelet - Elliot
        }

        
    }

    public void LoadMenu()
    {
       
        SceneManager.LoadScene("Olivers Scen"); //laddar "Olivers Scen" som innehåller MainMenu. -Oliver
        GameIsPaused = false;
    }
    public void QuitGame() 
    {
        Application.Quit(); //stänger spelet när man klickar på knappen med den funktionen. -Oliver
    }
}
