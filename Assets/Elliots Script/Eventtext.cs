using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Eventtext : MonoBehaviour
{
    TextMeshProUGUI eventText;

    string event1;

    

    string event1A = "Yes";

        string event1B = "No";

    bool event1Active;

    // Start is called before the first frame update

   
    void Start()
    {
        eventText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            eventText.text = event1;
            event1Active = true;
           
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
