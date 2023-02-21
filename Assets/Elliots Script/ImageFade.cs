using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//fader till knapparna så att de lyser när man har tryckt på de - Elliot
public class ImageFade : MonoBehaviour
{

    bool IsActive = false; //är en fade in aktiv

    // Start is called before the first frame update
    void Start()
    {
       

    }


    public void FadeIn() 
    {
        if(IsActive == false) 
        {
            StartCoroutine("RunFadeIn");
        }
       
    }

    public void FadeOut()

    {
        if (IsActive == true)
        {
            StartCoroutine("RunFadeOut");
        }
    }


    IEnumerator RunFadeIn() //den här delen fade-ar in en ny, ljusare, knapp-bild över gamla knapp-bilden
    {
        //Debug.Log("In");

        IsActive = true;

        

        Image img;

        Color offColor;

        Color onColor;

        img = this.GetComponent<Image>();

        offColor = img.color;

        offColor.a = 0;

        onColor = img.color;

        onColor.a = 1f;


        float fadeTime = 0.5f;

        float startTime = Time.time;

        float elapsedTime = 0;


        while (elapsedTime < fadeTime) //under tiden som knappen ska bli ljusare läggs opacitet till
        {
          

            elapsedTime = Time.time - startTime;

            img.color = Color.Lerp(offColor, onColor, elapsedTime / fadeTime);

            yield return new WaitForSeconds(0.05f);

        }

      


    }

   
    IEnumerator RunFadeOut() //tar långsamt bort nya bilden. Denna effekt används när man klickar på next week knappen
    {
        //Debug.Log("Out");

        IsActive = false;

        

        Image img;

        Color offColor; //färg när knappen är avstängd

        Color onColor; //färg när knappen är på

        img = this.GetComponent<Image>();

        offColor = img.color;

        offColor.a = 0;

        onColor = img.color;

        onColor.a = 1f;

        float fadeTime = 0.5f;

        float startTime = Time.time;

        float elapsedTime = 0f;

        while (elapsedTime < fadeTime) //under tiden som knappen ska bli ljusare tas opacitet bort
        {
            

            elapsedTime = Time.time - startTime;

            img.color = Color.Lerp(onColor, offColor, elapsedTime / fadeTime);

            yield return new WaitForSeconds(0.05f);

        }

        
    }

}
