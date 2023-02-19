using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// det h�r skriptet �r till knappen f�r att g� till n�sta vecka - Elliot. namnet p� skriptet �r fel men det �r sv�rt att �ndra nu
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

        
        
        if (Input.GetKeyDown(KeyCode.H)) //kan inte vara space, d� buggar spelet
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

            FindObjectOfType<GameManager>().week++; // l�gger till en vecka p� vecko-timern


            lastEventNumber = FindObjectOfType<GameManager>().eventArrayNumber;

            ToggleImage(lastEventNumber, false); // g�mmer gamla bilden

            nextEventNumber = Random.Range(0, 17); //v�ljer ett event av 18

            while (lastEventNumber == nextEventNumber) // ser till att inte samma event kommer tv� g�nger i rad
            {
                nextEventNumber = Random.Range(0, 17);
                //Debug.Log("Det h�nde"); // jag anv�nde den h�r f�r att testa
            }


            FindObjectOfType<GameManager>().eventArrayNumber = nextEventNumber;



            ToggleImage(nextEventNumber, true); //visar bilden
            


            if (!firstWeek) // f�rsta veckan ska inte ljudet f�r timglasset spelas, resten av veckorna ska det spelas
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

            ToggleImage(lastEventNumber, false); // g�mmer gamla bilden

        nextEventNumber = Random.Range(0, 17); //v�ljer ett event av 18

        while (lastEventNumber == nextEventNumber) // ser till att inte samma event kommer tv� g�nger i rad
        {
            nextEventNumber = Random.Range(0, 17);
            //Debug.Log("Det h�nde"); // jag anv�nde den h�r f�r att testa
        }


        FindObjectOfType<GameManager>().eventArrayNumber = nextEventNumber;



        ToggleImage(nextEventNumber, true); //visar bilden
    }

    public void UpdateImageOnResume() //updaterar bilden s� att r�tt bild visas efter man klickar resume (s� att man f�r r�tt bild efter man laddat save). Den g�mmer f�rst alla bilder, sedan visar den r�tt bild
    {

        HideAllImages(); 
      ToggleImage(FindObjectOfType<GameManager>().eventArrayNumber, true);
        //Debug.Log("UpdateImage2");
    }

    void HideAllImages() //g�mmer alla bilder
    {
     for(int i = 0; i < 18; i++) 
        {
            ToggleImage(i, false);
        
        }
    
    }

  public  void ToggleImage(int eventNumber, bool show) // visar r�tt bild
    {
        eventImage = GameObject.Find("Event " + eventNumber).GetComponent<SpriteRenderer>(); //tar bilden med r�tt namn (byt ej bild objektens namn i unity)

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
