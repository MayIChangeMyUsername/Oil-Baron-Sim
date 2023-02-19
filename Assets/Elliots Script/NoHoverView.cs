using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class NoHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // VIKTIGT: �ndra inte p� namnen p� pil-bilderna i main scenen i unity

    //det h�r skriptet visar �ndringen om man svarar no om man har musen �ver no-knappen
    string[] imageArray = new string[] {
        "", "1down", "2down", "3down", "1up", "2up", "3up", "Unknown" // Den h�r arrayen lagrar typen av pil, genom en del av namnet p� pil-objekten i unity. Senare i skriptet ges resten av namnet
    };

    int[,] eventEffectsArray = new int[,] // det h�r �r en array med effekterna av alla events. Varje nummer �r en plats i arrayen ovanf�r
    {
     {4, 1, 0 }, //event 0 effekt osv {money , reputation , sustain)
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
     {0, 0, 0},//13
     {0, 3, 0},//14
     {0, 0, 5},//15
     {0, 1, 0},//16
     {0, 2, 0}//17
     

    };



    public bool noButtonHover; //om man hoverar �ver "no" knappen eller inte

    Color tempColor; //tempor�r f�rg

    Image arrowImage; //pilen som ska visas

    TextMeshProUGUI arrowText;

    public void OnPointerEnter(PointerEventData eventdata)// n�r man b�rjar ha musen �ver knappen
    {
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            GetChange();// startar voiden
            noButtonHover = true;
        }


    }

    public void OnPointerExit(PointerEventData eventData)// n�r man tar bort muspekaren fr�n knappen
    {
        HideChange();
        noButtonHover = false;

    }

    void GetChange() 
    {
        // de tre f�ljande fr�gar game managern vilket event som �r aktivt och tar r�tt pil
        int mon = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 0];

        int rep = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 1];

        int sus = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 2];

        //de tre f�ljande kallar p� voiden en g�ng f�r varje stat. Inanf�r parentesen finns namnet p� ett objekt i spelet
        ShowChange("M" + imageArray[mon]); //varje pil har en bokstav i namnet som visar vilket stat som p�verkas. H�r kombineras r�tt stat (M, R eller S) med r�tt typ av pil. Piltyperna finns i en array l�ngs upp
        ShowChange("R" + imageArray[rep]);
        ShowChange("S" + imageArray[sus]);

    }

    void ShowChange(string imageRef)
    {
        //Debug.Log("bild" + imageRef);
        if (imageRef.Length > 1) //om namnet p� bilden �r l�ngre �n bara en symbol (s� att den inte p�verkar event effects array plats 0, vilket �r ingen bild)
        {
            // nedan tar bildens object, tar dess f�rg, och s�tter dess f�rgs transparans till max

            arrowImage = GameObject.Find(imageRef).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 1;

            arrowImage.color = tempColor;

            arrowText = arrowImage.GetComponentInChildren<TextMeshProUGUI>();

            tempColor = arrowText.color;

            tempColor.a = 1;

            arrowText.color = tempColor;
        }

    }

    public void HideChange()
    {
        for (int i = 1; i < imageArray.Length; i++) // den h�r s�tter alla bilders transparens till 0, vilket g�r de osynliga, tills alla har gjorts osynliga
        {
            //money
            arrowImage = GameObject.Find("M" + imageArray[i]).GetComponent<Image>(); //hittar r�tt, bild vare arrayen l�ngst upp

            tempColor = arrowImage.color; // tar pilens f�rg

            tempColor.a = 0; //s�tter alpha-v�rdet till 0 (allts� transparant)

            arrowImage.color = tempColor; //g�r bilden samma f�rg som tempcolor, allts� transparant

            arrowText = arrowImage.GetComponentInChildren<TextMeshProUGUI>(); //hittar r�tt text

            tempColor = arrowText.color; // tar textens f�rg

            tempColor.a = 0;

            arrowText.color = tempColor;

            //rep

            arrowImage = GameObject.Find("R" + imageArray[i]).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 0;

            arrowImage.color = tempColor;

            arrowText = arrowImage.GetComponentInChildren<TextMeshProUGUI>();

            tempColor = arrowText.color;

            tempColor.a = 0;

            arrowText.color = tempColor;

            //sus

            arrowImage = GameObject.Find("S" + imageArray[i]).GetComponent<Image>();

            tempColor = arrowImage.color;

            tempColor.a = 0;

            arrowImage.color = tempColor;

            arrowText = arrowImage.GetComponentInChildren<TextMeshProUGUI>();

            tempColor = arrowText.color;

            tempColor.a = 0;

            arrowText.color = tempColor;
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
