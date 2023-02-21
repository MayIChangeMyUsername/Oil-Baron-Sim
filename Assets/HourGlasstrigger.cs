using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourGlasstrigger : MonoBehaviour //Skriven av Axel f�rutom d�r det st�r Elliot
{
    //Scriptet aktiverar animatorn n�r man skippar till n�sta vecka (Antingen via skip knappen eller via keybind) 
    Animator myanimator; 
    public Button button;


    const string Trigger_ANIM = "Trigger";


    void Start()
    {
        myanimator = GetComponent<Animator>();
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (FindObjectOfType<GameManager>().eventActive == false) //Elliot
            {
                myanimator.SetTrigger(Trigger_ANIM); //Elliot
            }
        }


    }
    void TaskOnClick() //Elliot
    {
        if(FindObjectOfType<GameManager>().eventActive == false) //Elliot
        {
            myanimator.SetTrigger(Trigger_ANIM); //Elliot
        }
        
    }

}
