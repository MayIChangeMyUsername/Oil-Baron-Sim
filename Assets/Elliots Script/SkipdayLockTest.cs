using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkipdayLockTest : MonoBehaviour
{
    Color tempAlpha;

    SpriteRenderer eventImage;
   

    public Button yourButton;

    int lastEventNumber;

    int nextEventNumber;


    //List<string> eventList2 = new List<string>();


  


    // Start is called before the first frame update
    void Start()
    {


      
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        FindObjectOfType<GameManager>().eventActive = false;
        TaskOnClick();
        
    }

    // Update is called once per frame
    void Update()
    {
        
       

    }

    void TaskOnClick()
    {
        if(FindObjectOfType<GameManager>().eventActive  == false) 
        {
            FindObjectOfType<GameManager>().eventActive = true;

            GameManager.week++;
            lastEventNumber = FindObjectOfType<GameManager>().eventArrayNumber;

            ToggleImage(lastEventNumber, false); // gömmer gamla bilden

            nextEventNumber = Random.Range(0, 17);

            while (lastEventNumber == nextEventNumber) // ser till att inte samma event kommer två gånger i rad
            {
                nextEventNumber = Random.Range(0, 17);
                //Debug.Log("Det hände"); // jag använde den här för att testa
            }

            FindObjectOfType<GameManager>().eventArrayNumber = nextEventNumber;

            

            ToggleImage(nextEventNumber, true); //visar bilden

        }

        void ToggleImage(int eventNumber, bool show) // visar rätt bild
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
}
