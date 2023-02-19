using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class NoHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // VIKTIGT: ändra inte på namnen på pil-bilderna i main scenen i unity

    //det här skriptet visar ändringen om man svarar no om man har musen över no-knappen
    string[] imageArray = new string[] {
        "", "1down", "2down", "3down", "1up", "2up", "3up", "Unknown" // Den här arrayen lagrar typen av pil, genom en del av namnet på pil-objekten i unity. Senare i skriptet ges resten av namnet
    };

    int[,] eventEffectsArray = new int[,] // det här är en array med effekterna av alla events. Varje nummer är en plats i arrayen ovanför
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



    public bool noButtonHover; //om man hoverar över "no" knappen eller inte

    Color tempColor; //temporär färg

    Image arrowImage; //pilen som ska visas

    TextMeshProUGUI arrowText;

    public void OnPointerEnter(PointerEventData eventdata)// när man börjar ha musen över knappen
    {
        if (FindObjectOfType<GameManager>().eventActive == true)
        {
            GetChange();// startar voiden
            noButtonHover = true;
        }


    }

    public void OnPointerExit(PointerEventData eventData)// när man tar bort muspekaren från knappen
    {
        HideChange();
        noButtonHover = false;

    }

    void GetChange() 
    {
        // de tre följande frågar game managern vilket event som är aktivt och tar rätt pil
        int mon = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 0];

        int rep = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 1];

        int sus = eventEffectsArray[FindObjectOfType<GameManager>().eventArrayNumber, 2];

        //de tre följande kallar på voiden en gång för varje stat. Inanför parentesen finns namnet på ett objekt i spelet
        ShowChange("M" + imageArray[mon]); //varje pil har en bokstav i namnet som visar vilket stat som påverkas. Här kombineras rätt stat (M, R eller S) med rätt typ av pil. Piltyperna finns i en array längs upp
        ShowChange("R" + imageArray[rep]);
        ShowChange("S" + imageArray[sus]);

    }

    void ShowChange(string imageRef)
    {
        //Debug.Log("bild" + imageRef);
        if (imageRef.Length > 1) //om namnet på bilden är längre än bara en symbol (så att den inte påverkar event effects array plats 0, vilket är ingen bild)
        {
            // nedan tar bildens object, tar dess färg, och sätter dess färgs transparans till max

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
        for (int i = 1; i < imageArray.Length; i++) // den här sätter alla bilders transparens till 0, vilket gör de osynliga, tills alla har gjorts osynliga
        {
            //money
            arrowImage = GameObject.Find("M" + imageArray[i]).GetComponent<Image>(); //hittar rätt, bild vare arrayen längst upp

            tempColor = arrowImage.color; // tar pilens färg

            tempColor.a = 0; //sätter alpha-värdet till 0 (alltså transparant)

            arrowImage.color = tempColor; //gör bilden samma färg som tempcolor, alltså transparant

            arrowText = arrowImage.GetComponentInChildren<TextMeshProUGUI>(); //hittar rätt text

            tempColor = arrowText.color; // tar textens färg

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
