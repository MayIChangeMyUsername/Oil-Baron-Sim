using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class HoverViewStat : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool buttonClick;

    public void OnPointerEnter(PointerEventData eventdata)
    {

        buttonClick = true;
        Debug.Log("over");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonClick = false;
        Debug.Log("no");
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
