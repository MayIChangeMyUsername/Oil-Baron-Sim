using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame ()
    {
        SceneManager.LoadScene("Main Scen"); //laddar nästa scen när man klickar på en button med playgame (). -oliver //Jag ändrade från "buildIndex + 1" till "Main Scen" så att skriptet inte slutar fungera om man råkar ändra build ordning - Elliot
    }
    public void QuitGame() //Lämnar spelet. 
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
