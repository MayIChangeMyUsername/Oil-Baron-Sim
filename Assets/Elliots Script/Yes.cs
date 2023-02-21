using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yes : MonoBehaviour
{
    public Button yourButton;


    ImageFade yesImage;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        yesImage = GetComponentInChildren<ImageFade>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            TaskOnClick();

        }
    }

    void TaskOnClick()
    {
        if (FindObjectOfType<GameManager>().eventActive == true) //om ett event �r aktivt g�r ja knappen det den ska
        {
            
            FindObjectOfType<GameManager>().eventYes = true; //ja-svar skickas till game manager d�r stats �ndras utifr�n vilket event som �r aktivt
            FindObjectOfType<YesHoverView>().HideChange(); //preview av event effekter slutar
            GameObject.Find("YesLjud").GetComponent<AudioSource>().Play(); //ljudet f�r ja spelar

            yesImage.FadeIn(); //funktion i ImageFade. en ny knapp-bild b�rjar bli synlig, s� att knappen verkar lysa upp
        }
            
    }
}
