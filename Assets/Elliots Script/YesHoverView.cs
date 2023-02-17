using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class YesHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    // VIKTIGT: �ndra inte p� namnen p� pil-bilderna

    //det h�r skriptet visar �ndringen om man svarar ja om man har musen �ver ja-knappen
    string[] imageArray = new string[] {  
        "", "1down", "2down", "3down", "1up", "2up", "3up", "Unknown"  // det h�r �r alla bildernas namn
    };

    int[,] eventEffectsArray = new int[,] // det h�r �r en array med effekterna av alla events. Varje nummer �r en plats i arrayen ovanf�r
    {
     {1, 4, 0 }, //event 0 effekt osv {money , reputation , sustain)
     {5, 0, 2}, //1
     {2, 2, 0}, //2
     {1, 1, 0}, //3
     {1, 0, 2}, //4
     {5, 4, 2},//5
     {1, 6, 0},//6
     {4, 0, 1},//7
     {4, 4, 2},//8
     {7, 0, 0}, //9
     {1, 2, 0}, //10
     {2, 0, 4},//11
     {2, 0, 0},//12
     {1, 4, 0},//13
     {1, 7, 0},//14
     {5, 4, 0},//15
     {2, 6, 4},//16
     {1, 1, 0}//17
     

    };

  

    public bool yesButtonHover;

    Color tempColor;

    Image arrowImage;



    public void OnPointerEnter(PointerEventData eventdata) // n�r man b�rjar ha musen �ver knappen
    {
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            GetChange(); // startar voiden
            yesButtonHover = true;
        }
       
        
    }

    public void OnPointerExit(PointerEventData eventData) // n�r man tar bort muspekaren fr�n knappen
    {
        HideChange();
        yesButtonHover = false;
        
    }

        void GetChange() 
    {

        // de tre f�ljande fr�gar game managern vilket event som �r aktivt och tar r�tt pil
        int  mon = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 0];

        int rep = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 1];

        int sus = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 2];

        //de tre f�ljande kallar p� voiden en g�ng per stat. Inanf�r parentesen finns namnet p� ett objekt i spelet
        ShowChange("M" + imageArray[mon]);
        ShowChange("R" + imageArray[rep]);
        ShowChange("S" + imageArray[sus]);

    }

    void ShowChange(string imageRef) 
    {
        //Debug.Log("bild" + imageRef);
        if(imageRef.Length > 1) // om namnet p� bilden �r l�ngre �n bara en symbol (s� att den inte p�verkar event effects array plats 0, vilket �r ingen bild)
        {
            // nedan tar bildens object, tar dess f�rg, och s�tter dess f�rgs transparans till max

            arrowImage = GameObject.Find(imageRef).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 1;

            arrowImage.color = tempColor;
        }
   
    }
   
   public void HideChange() 
    {
        for (int i = 1; i < imageArray.Length; i++) // den h�r s�tter alla bilders transparens till 0, vilket g�r de osynliga, tills alla har gjorts osynliga
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

    // bara gammal kod nedanf�r

    // Start is called before the first frame update
    void Start()
    {

        //string[] imageArray = new string[] { "", "1down", "2down", "3down", "1up", "2up", "3up", "Unknown" };

        

    }

    // Update is called once per frame
    void Update()
    {
        // gammal kod

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
