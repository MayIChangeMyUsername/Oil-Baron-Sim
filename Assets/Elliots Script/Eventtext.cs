using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Eventtext : MonoBehaviour
{
   public TextMeshProUGUI eventText;

    List <string> eventList= new List<string>();

    

    string event1;

    

    string event1A = "Yes";

        string event1B = "No";

    bool event1Active;

   // bool eventActive; //den här kan man använda för att se till att man inte kan skippa ett event genom att byta dag


    // Start is called before the first frame update

   
    void Start()
    {
        eventText = GameObject.Find("Eventtext").GetComponent<TextMeshProUGUI>();

        eventList.Add("Would you like to build a new factory?");
    
    
    }

   

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.W))//kanske fungerar
        {
            eventText.text = eventList[0];
            event1Active = true;
           // eventActive = true;
        }
        if (event1Active == true)
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

       
    }
}
