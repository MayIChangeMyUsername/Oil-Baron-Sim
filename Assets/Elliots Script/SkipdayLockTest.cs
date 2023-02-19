using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// det här skriptet är till knappen för att gå till nästa vecka - Elliot. namnet på skriptet är fel men det är svårt att ändra nu
public class SkipdayLockTest : MonoBehaviour
{
    Color tempAlpha;

    SpriteRenderer eventImage;
   

    public Button yourButton;

    int lastEventNumber;

    public int nextEventNumber;

    bool firstWeek;

    //List<string> eventList2 = new List<string>();

    GameObject Yes;

    GameObject No;

    Button btn;


    // Start is called before the first frame update
    void Start()
    {


      
        btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        FindObjectOfType<GameManager>().eventActive = false;
        firstWeek = true;
       

        Yes = GameObject.Find("On(Yes2)");
        
        No = GameObject.Find("On(No2)");

        TaskOnClick();
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if (Input.GetKeyDown(KeyCode.H)) //kan inte vara space, då buggar spelet
        {
            TaskOnClick();

        }

        if (FindObjectOfType<GameManager>().eventActive == false) 
        {

            btn.interactable = true;

        }
        else 
        {
            btn.interactable = false;
        }
    }

    void TaskOnClick()
    {
        if(FindObjectOfType<GameManager>().eventActive  == false) 
        {
            FindObjectOfType<GameManager>().eventActive = true;

            FindObjectOfType<GameManager>().week++; // lägger till en vecka på vecko-timern


            lastEventNumber = FindObjectOfType<GameManager>().eventArrayNumber;

            ToggleImage(lastEventNumber, false); // gömmer gamla bilden

            nextEventNumber = Random.Range(0, 17); //väljer ett event av 18

            while (lastEventNumber == nextEventNumber) // ser till att inte samma event kommer två gånger i rad
            {
                nextEventNumber = Random.Range(0, 17);
                //Debug.Log("Det hände"); // jag använde den här för att testa
            }


            FindObjectOfType<GameManager>().eventArrayNumber = nextEventNumber;



            ToggleImage(nextEventNumber, true); //visar bilden
            


            if (!firstWeek) // första veckan ska inte ljudet för timglasset spelas, resten av veckorna ska det spelas
            {
                GameObject.Find("Timglas").GetComponent<AudioSource>().Play();

                Yes.GetComponent<ImageFade>().FadeOut();

                No.GetComponent<ImageFade>().FadeOut();

                FindObjectOfType<GameManager>().SavePlayer();
            }

            if (firstWeek == true)
            {
                firstWeek = false;

            }    
            
        }


    }

   public void RollEventDice() 
   {

        
        lastEventNumber = FindObjectOfType<GameManager>().eventArrayNumber;

            ToggleImage(lastEventNumber, false); // gömmer gamla bilden

        nextEventNumber = Random.Range(0, 17); //väljer ett event av 18

        while (lastEventNumber == nextEventNumber) // ser till att inte samma event kommer två gånger i rad
        {
            nextEventNumber = Random.Range(0, 17);
            //Debug.Log("Det hände"); // jag använde den här för att testa
        }


        FindObjectOfType<GameManager>().eventArrayNumber = nextEventNumber;



        ToggleImage(nextEventNumber, true); //visar bilden
    }

    public void UpdateImageOnResume() //updaterar bilden så att rätt bild visas efter man klickar resume (så att man får rätt bild efter man laddat save). Den gömmer först alla bilder, sedan visar den rätt bild
    {

        HideAllImages(); 
      ToggleImage(FindObjectOfType<GameManager>().eventArrayNumber, true);
        //Debug.Log("UpdateImage2");
    }

    void HideAllImages() //gömmer alla bilder
    {
     for(int i = 0; i < 18; i++) 
        {
            ToggleImage(i, false);
        
        }
    
    }

  public  void ToggleImage(int eventNumber, bool show) // visar rätt bild
    {
        eventImage = GameObject.Find("Event " + eventNumber).GetComponent<SpriteRenderer>(); //tar bilden med rätt namn (byt ej bild objektens namn i unity)

        tempAlpha = eventImage.color;

        if (show)
        {
            tempAlpha.a = 1;

        }
        else
        {
            tempAlpha.a = 0;

        }



        eventImage.color = tempAlpha;



    }
}
