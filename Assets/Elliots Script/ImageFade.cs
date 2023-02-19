using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFade : MonoBehaviour
{

    bool IsActive = false;

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


    IEnumerator RunFadeIn()
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


        while (elapsedTime < fadeTime)
        {
          

            elapsedTime = Time.time - startTime;

            img.color = Color.Lerp(offColor, onColor, elapsedTime / fadeTime);

            yield return new WaitForSeconds(0.05f);

        }

      


    }

   
    IEnumerator RunFadeOut()
    {
        //Debug.Log("Out");

        IsActive = false;

        

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

        float elapsedTime = 0f;

        while (elapsedTime < fadeTime)
        {
            

            elapsedTime = Time.time - startTime;

            img.color = Color.Lerp(onColor, offColor, elapsedTime / fadeTime);

            yield return new WaitForSeconds(0.05f);

        }

        
    }

}
