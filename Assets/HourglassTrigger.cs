using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourglassTrigger : MonoBehaviour
{
    
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myanimator.SetTrigger(Trigger_ANIM);
        }
        

    }
    void TaskOnClick()
    {  
     myanimator.SetTrigger(Trigger_ANIM); 
    }

}
