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

  public  bool eventActive; //den här kan man använda för att se till att man inte kan skippa ett event genom att byta dag

    int eventNumber;

    bool yes;

    int sustainAmnt;

    int moneyAmnt;

    int reputationAmnt;

    int smallAmnt = 10;

    //bool no;

    // Start is called before the first frame update


    void Start()
    {
        

        eventActive = true;

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
        eventActive = FindObjectOfType<SkipdayLockTest>().eventBlock;

        yes = FindObjectOfType<Yes>().yes1;

        sustainAmnt = FindObjectOfType<GameManager>().sustain;

        moneyAmnt = FindObjectOfType<GameManager>().money;

        reputationAmnt = FindObjectOfType<GameManager>().reputation;

        eventNumber = FindObjectOfType<SkipdayLockTest>().eventNum;

        eventText.text = eventList[eventNumber];
         
           
        if(yes == true) 
        {
            moneyAmnt = moneyAmnt - smallAmnt;
            eventActive = false;
            yes = false;
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
