using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextFader : MonoBehaviour
{

   

    TextMeshProUGUI endText;

    float textAlpha = 0f;

    // Start is called before the first frame update
    void Start()
    {



        endText = GameObject.Find("endText").GetComponent<TextMeshProUGUI>();
        endText.color = new Color(0f, 0f, 0f, textAlpha);


        if(SceneManager.GetActiveScene().name == "MoneyEnding") 
        {
            endText.text = "WEEK: " + PlayerPrefs.GetInt("week").ToString() + "<br> HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString() + "<br>MONEY: 0<br>PRESS ESCAPE<br>TO CONTINUE";
        }
        
        if (SceneManager.GetActiveScene().name == "ReputationEnding")
        {
            endText.text = "WEEK: " + PlayerPrefs.GetInt("week").ToString() + "<br> HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString() + "<br>REPUTATION: 0<br>PRESS ESCAPE<br>TO CONTINUE";
        }

        if (SceneManager.GetActiveScene().name == "SustainEnding")
        {
            endText.text = "WEEK: " + PlayerPrefs.GetInt("week").ToString() + "<br> HIGHSCORE: " + PlayerPrefs.GetInt("HighScore").ToString() + "<br>SUSTAINABILITY: 0<br>PRESS ESCAPE<br>TO CONTINUE";
        }
    }

    // Update is called once per frame
    void Update()
    {

        textAlpha = textAlpha + 0.00225f; // l�gger till transparens
        if (endText.color != new Color(0f, 0f, 0f, 1f))  //slutar l�gga till n�r texten �r helt synlig
        {
            endText.color = new Color(0f, 0f, 0f, textAlpha);
            
        }
            


    }
}
