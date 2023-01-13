using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Yes : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonClick;

    public bool yes1;

    public void OnPointerDown(PointerEventData eventdata)
    {
        yes1 = true;
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
        
    }
}
