using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class YesHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    string[] imageArray = new string[] {
        "", "1down", "2down", "3down", "1up", "2up", "3up", "Unknown"
    };

    int[,] eventEffectsArray = new int[,] 
    {
     {1, 4, 0 }, //event 0 effekt osv {m , r , s)
     {5, 0, 2}, //1
     {2, 2, 0}, //2
     {1, 1, 0}, //3
     {1, 0, 2}, //4
     {5, 0, 1},//5
     {1, 6, 0},//6
     {4, 0, 0},//7
     {4, 4, 2},//8
     {7, 0, 0}, //9
     {1, 2, 0}, //10
     {2, 0, 4},//11
     {2, 0, 0},//12
     {0, 5, 0},//13
     {1, 7, 0},//14
     {6, 0, 0},//15
     {2, 6, 4},//16
     {1, 1, 0}//17
     

    };

  

    public bool yesButtonHover;

    Color tempColor;

    Image arrowImage;



    public void OnPointerEnter(PointerEventData eventdata)
    {
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            GetChange();
            yesButtonHover = true;
        }
       
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HideChange();
        yesButtonHover = false;
        
    }

        void GetChange() 
    {
        int  mon = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 0];

        int rep = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 1];

        int sus = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 2];


        ShowChange("M" + imageArray[mon]);
        ShowChange("R" + imageArray[rep]);
        ShowChange("S" + imageArray[sus]);

    }

    void ShowChange(string imageRef) 
    {
        //Debug.Log("bild" + imageRef);
        if(imageRef.Length > 1) 
        {
            arrowImage = GameObject.Find(imageRef).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 1;

            arrowImage.color = tempColor;
        }
   
    }
   
   public void HideChange() 
    {
        for (int i = 1; i < imageArray.Length; i++ )
        {
            arrowImage = GameObject.Find("M" + imageArray[i]).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 0;

            arrowImage.color = tempColor;

            arrowImage = GameObject.Find("R" + imageArray[i]).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 0;

            arrowImage.color = tempColor;

            arrowImage = GameObject.Find("S" + imageArray[i]).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 0;

            arrowImage.color = tempColor;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        //string[] imageArray = new string[] { "", "1down", "2down", "3down", "1up", "2up", "3up", "Unknown" };

        

    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (yesButtonHover == true) 
        {
            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 0) 
            {
                arrowImage1 = GameObject.Find("M1down").GetComponent<Image>();

                arrowImage2 = GameObject.Find("R1up").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;

                arrowImage2.color = tempColor;
            }
        */

         
        
    }
}
