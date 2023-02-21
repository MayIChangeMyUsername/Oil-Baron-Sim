using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//fader till knapparna s� att de lyser n�r man har tryckt p� de - Elliot
public class ImageFade : MonoBehaviour
{

    bool IsActive = false; //�r en fade in aktiv

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


    IEnumerator RunFadeIn() //den h�r delen fade-ar in en ny, ljusare, knapp-bild �ver gamla knapp-bilden
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


        while (elapsedTime < fadeTime) //under tiden som knappen ska bli ljusare l�ggs opacitet till
        {
          

            elapsedTime = Time.time - startTime;

            img.color = Color.Lerp(offColor, onColor, elapsedTime / fadeTime);

            yield return new WaitForSeconds(0.05f);

        }

      


    }

   
    IEnumerator RunFadeOut() //tar l�ngsamt bort nya bilden. Denna effekt anv�nds n�r man klickar p� next week knappen
    {
        //Debug.Log("Out");

        IsActive = false;

        

        Image img;

        Color offColor; //f�rg n�r knappen �r avst�ngd

        Color onColor; //f�rg n�r knappen �r p�

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
