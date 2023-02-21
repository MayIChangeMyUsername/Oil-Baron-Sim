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
        if (FindObjectOfType<GameManager>().eventActive == true) //om ett event är aktivt gör ja knappen det den ska
        {
            
            FindObjectOfType<GameManager>().eventYes = true; //ja-svar skickas till game manager där stats ändras utifrån vilket event som är aktivt
            FindObjectOfType<YesHoverView>().HideChange(); //preview av event effekter slutar
            GameObject.Find("YesLjud").GetComponent<AudioSource>().Play(); //ljudet för ja spelar

            yesImage.FadeIn(); //funktion i ImageFade. en ny knapp-bild börjar bli synlig, så att knappen verkar lysa upp
        }
            
    }
}
