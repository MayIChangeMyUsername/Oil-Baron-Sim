using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame ()
    {
        SceneManager.LoadScene("Main Scen"); //laddar n�sta scen n�r man klickar p� en button med playgame (). -oliver //Jag �ndrade fr�n "buildIndex + 1" till "Main Scen" s� att skriptet inte slutar fungera om man r�kar �ndra build ordning - Elliot
    }
    public void QuitGame() //L�mnar spelet. 
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
