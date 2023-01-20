using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopbutton1 : MonoBehaviour
{


    public Button button;




    void Start()
    {

        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }



    private void Update()
    {



    }
    void TaskOnClick()
    {
        FindObjectOfType<GameManager>().money -= 50;
        FindObjectOfType<GameManager>().sustain += 50;
        FindObjectOfType<GameManager>().reputation -= 50;
    }

}
