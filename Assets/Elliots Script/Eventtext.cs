using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Eventtext : MonoBehaviour
{
   TextMeshProUGUI eventText;

   List <string> eventList= new List<string>();

    

   //string event1;

    

    //string event1A = "Yes";

       // string event1B = "No";

    //bool event1Active;

  //den h�r kan man anv�nda f�r att se till att man inte kan skippa ett event genom att byta dag

    int eventNumber;

    bool yes;



    int smallAmnt = 10;

    //bool no;

    // Start is called before the first frame update


    void Start()
    {
        

        

        eventText = GameObject.Find("Eventtext").GetComponent<TextMeshProUGUI>();

 

        eventList.Add("Would you like to build a new factory?");

        eventList.Add("Protests!?");

        eventList.Add("Placeholder!");

        eventList.Add("Hello");

        eventList.Add("Hello");

        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");
        eventList.Add("Hello");

    }



    // Update is called once per frame
    void Update()
    {


        yes = FindObjectOfType<Yes>().yes1;


        eventNumber = FindObjectOfType<SkipdayLockTest>().eventNum;

        eventText.text = eventList[GameManager.week];
         
           
        if(yes == true) 
        {
            FindObjectOfType<GameManager>().money = FindObjectOfType<GameManager>().money - smallAmnt;
            FindObjectOfType<SkipdayLockTest>().eventBlock = false;
            yes = false;
            FindObjectOfType<Yes>().yes1 = false;
            
        }

        /* if (event1Active == true)
         {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                eventText.text = event1A;
                event1Active = false;
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                eventText.text = event1B;
                event1Active = false;
            }
        }
        */
       
    }
}
