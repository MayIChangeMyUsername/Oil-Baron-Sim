using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SkipDaytest : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonClick;

    int testNumber;

    public void OnPointerDown(PointerEventData eventdata) 
    {
        buttonClick = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonClick = false;
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(buttonClick == true) 
        {
            
            testNumber = FindObjectOfType<GameManager>().money;
            testNumber = 90;
        }
    }

   

}
