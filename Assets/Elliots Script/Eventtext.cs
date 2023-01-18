using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Eventtext : MonoBehaviour
{
   TextMeshProUGUI eventText;

    string[] eventArray = new string[] { "Consumers want lower prices, do you want to reduce prices?",
       "A landowner offers to sell an area rich in oil for a medium sum of money. Extracting the oil will take a few weeks. Do you accept the deal?",
       "The stock market has crashed! Do you want to sell parts of your land?",
   "Bad rumours about your corporation have begun spread.",
   "An oil leak has appeared and oil is pouring into the ocean",
   "Oil consumption has increased and your stocks are rising in value",
   "Through advertising on social media people's opinion of your company has increased. Do you want to spend more money on social media advertising?",
   "A more effective way of producing oil has been developed!",
   "Demand for oil has rapidly begun increasing. Do you want to accelerate the production rate to satifsy the demand?",
   "You have recieved a phone call from a potential swindler. Do you want to answer?",
   "One of your oil rigs is in need of massive repairs. You could either hire experienced workers who can repair without harming marine life or let your own workers repair despite the damage it would cause",
   "One of your oil tankers has sunk leaving large amounts of oil in the ocean. Do you want to clean it up?",
   "A reporter has asked for a tour on one of your oil rigs. Do you accept the request?",
   "A competing oil corporation has caused a extraordinarily large oil spillage. This has caused outrage against the oil industry. Do you wish to make a public statement?",
   "The government has subsidised your company.",
   "An oil extraction method which is much less harmfull for nature has been invented. However it is also more expensive. Do you want to adopt the new method?",
   "A news site has just published a hit piece, detailing some of our shady business practices. How will you respond?"
   };

    string[] yesEffectArray = new string[] {"" };


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



        /*eventArray[2] = "Stock market crashes!";

        eventArray[3] = "Bad rumours are spreading about your corporation";

        eventArray[4] = "An oil pipeline is leaking";

        eventArray[5] = "Stocks rise in value and sales are increasing";

        eventArray[6] = "You have gained traction on social media and more people buy oil";

        eventArray[7] = "A more effective way of extracting oil has been invented";*/
    }



    // Update is called once per frame
    void Update()
    {

        eventText.text = eventArray[FindObjectOfType<SkipdayLockTest>().eventArrayNumber];
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
