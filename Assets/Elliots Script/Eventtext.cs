using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Eventtext : MonoBehaviour
{
   TextMeshProUGUI eventText;

   string[] eventArray= new string[100];

   

   //string event1;

    

    //string event1A = "Yes";

       // string event1B = "No";

    //bool event1Active;

  //den här kan man använda för att se till att man inte kan skippa ett event genom att byta dag

   

   // bool yes;



    //int smallAmnt = 10;

    //bool no;

    // Start is called before the first frame update


    void Start()
    {
        

        

        eventText = GameObject.Find("Eventtext").GetComponent<TextMeshProUGUI>();

        eventArray[0] = "Consumers want lower prices, do you want to reduce prices?";

        eventArray[1] = "";

        eventArray[2] = "Stock market crashes!";

        eventArray[3] = "Bad rumours are spreading about your corporation";

        eventArray[4] = "An oil pipeline is leaking";

        eventArray[5] = "Stocks rise in value and sales are increasing";

        eventArray[6] = "You have gained traction on social media and more people buy oil";

        eventArray[7] = "A more effective way of extracting oil has been invented";
    }



    // Update is called once per frame
    void Update()
    {

        eventText.text = eventArray[GameManager.week];
        /*

                yes = FindObjectOfType<Yes>().yes1;




               


                if(yes == true) 
                {
                    //FindObjectOfType<GameManager>().money = FindObjectOfType<GameManager>().money - smallAmnt;
                    FindObjectOfType<SkipdayLockTest>().eventBlock = false;
                    yes = false;
                    FindObjectOfType<Yes>().yes1 = false;

                }*/

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
