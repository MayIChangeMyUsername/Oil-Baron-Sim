using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class YesHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool yesButtonHover;

    Color tempColor;

    Image arrowImage;

    

    public void OnPointerEnter(PointerEventData eventdata)
    {

        yesButtonHover = true;
        Debug.Log("over");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        yesButtonHover = false;
        Debug.Log("no");
    }

        void DisplayImage() 
    { 
    
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (yesButtonHover == true) 
        {
            arrowImage = GameObject.Find("S1down").GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 1;

            arrowImage.color = tempColor;

        }
        else 
        {
            arrowImage = GameObject.Find("S1down").GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 0;

            arrowImage.color = tempColor;

            
        }
        
        
    }
}
