using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class YesHoverView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool yesButtonHover;

    Color tempColor;

    Image arrowImage1;

    Image arrowImage2;

    Image arrowImage3;

    Image arrowImage4;

    Image arrowImage5;

    Image arrowImage6;

    public void OnPointerEnter(PointerEventData eventdata)
    {

        yesButtonHover = true;
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        yesButtonHover = false;
        
    }

        void DisplayS1up() 
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;


    }

    void DisplayS2up()
    {

        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;
    }

    void DisplayS3up()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayR1up()
    {

        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;
    }

    void DisplayR2up()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;


    }

    void DisplayR3up()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayM1up()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayM2up()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayM3up()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayS1down()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayS2down()
    {
        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayS3down()
    {

        arrowImage1 = GameObject.Find("S1up").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;
    }

    void DisplayR1down()
    {

        arrowImage1 = GameObject.Find("R1down").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;
    }

    void DisplayR2down()
    {

        arrowImage1 = GameObject.Find("R2down").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;
    }

    void DisplayR3down()
    {

        arrowImage1 = GameObject.Find("R3down").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;
    }

    void DisplayM1down()
    {
        arrowImage1 = GameObject.Find("M1down").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

    }

    void DisplayM2down()
    {

        arrowImage1 = GameObject.Find("M2down").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;
    }

    void DisplayM3down()
    {
        arrowImage1 = GameObject.Find("M3down").GetComponent<Image>();

        tempColor = arrowImage1.color;

        tempColor.a = 1;

        arrowImage1.color = tempColor;

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
            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 0) 
            {
                arrowImage1 = GameObject.Find("M1down").GetComponent<Image>();

                arrowImage2 = GameObject.Find("R1up").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;

                arrowImage2.color = tempColor;
            }


            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 1)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 2)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 3)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 4)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 5)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 6)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 7)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 8)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 9)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 10)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 11)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 12)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 13)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 14)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 15)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 16)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            if (FindObjectOfType<SkipdayLockTest>().nextEventNumber == 17)
            {
                arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

                tempColor = arrowImage1.color;

                tempColor.a = 1;

                arrowImage1.color = tempColor;
            }

            


        }
        else 
        {
            arrowImage1 = GameObject.Find("S1down").GetComponent<Image>();

            tempColor = arrowImage1.color;

            tempColor.a = 0;

            arrowImage1.color = tempColor;

            
        }
        
        
    }
}
