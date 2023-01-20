using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class NoHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    string[] imageArray = new string[] {
        "", "1down", "2down", "3down", "1up", "2up", "3up", "Unknown"
    };

    int[,] eventEffectsArray = new int[,]
    {
     {4, 1, 0 }, //event 0 effekt osv {m , r , s)
     {0, 4, 0}, //1
     {3, 0, 0}, //2
     {0, 2, 0}, //3
     {0, 2, 2}, //4
     {6, 0, 2},//5
     {0, 5, 0},//6
     {0, 4, 0},//7
     {2, 0, 5},//8
     {0, 0, 0}, //9
     {0, 3, 0}, //10
     {0, 1, 2},//11
     {0, 2, 3},//12
     {0, 1, 0},//13
     {0, 3, 0},//14
     {0, 2, 0},//15
     {0, 1, 0},//16
     {0, 2, 0}//17
     

    };



    public bool noButtonHover;

    Color tempColor;

    Image arrowImage;



    public void OnPointerEnter(PointerEventData eventdata)
    {
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            GetChange();
            noButtonHover = true;
        }


    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HideChange();
        noButtonHover = false;

    }

    void GetChange()
    {
        int mon = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 0];

        int rep = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 1];

        int sus = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 2];


        ShowChange("M" + imageArray[mon]);
        ShowChange("R" + imageArray[rep]);
        ShowChange("S" + imageArray[sus]);

    }

    void ShowChange(string imageRef)
    {
        //Debug.Log("bild" + imageRef);
        if (imageRef.Length > 1)
        {
            arrowImage = GameObject.Find(imageRef).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 1;

            arrowImage.color = tempColor;
        }

    }

    public void HideChange()
    {
        for (int i = 1; i < imageArray.Length; i++)
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
