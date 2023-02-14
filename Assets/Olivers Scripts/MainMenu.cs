using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //laddar n�sta scen n�r man klickar p� en button med playgame (). -oliver
    }
    public void QuitGame() //L�mnar spelet. 
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
