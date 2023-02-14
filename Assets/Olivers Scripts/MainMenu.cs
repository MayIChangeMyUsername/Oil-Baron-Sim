using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //laddar nästa scen när man klickar på en button med playgame (). -oliver
    }
    public void QuitGame() //Lämnar spelet. 
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
