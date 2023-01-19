using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class NoHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool noButtonHover;

    public void OnPointerEnter(PointerEventData eventdata)
    {

        noButtonHover = true;
        Debug.Log("over");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        noButtonHover = false;
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
