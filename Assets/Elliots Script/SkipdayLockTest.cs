using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
public class SkipdayLockTest : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    

    public bool buttonClick;

    public void OnPointerDown(PointerEventData eventdata)
    {
        buttonClick = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonClick = false;
    }

    //List<string> eventList2 = new List<string>();

    bool eventBlock;

    public int eventNum;

    // Start is called before the first frame update
    void Start()
    {
        //eventList2 = FindObjectOfType<Eventtext>().eventList;


    }

    // Update is called once per frame
    void Update()
    {
        eventBlock =FindObjectOfType<Eventtext>().eventActive;
        STND();

    }

    void STND()
    {
        if (buttonClick == true && eventBlock == false)
        {
            eventBlock = true;
            eventNum++;
            GameManager.week++;
        }
    }
}
