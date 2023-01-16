using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public int money;

   public int sustain;

   public int reputation;


    // olika mängder som ändrar på tex money värdet i event
    int smallAmount = 15; 

    int mediumAmount = 30;

    int largeAmount = 45;

    public static int week = 0;
    public static int click = 1;

    public static bool clicki = true;

    public Text weekText;
    public Text clickText;
    public Text moneyttxt;
    public Text sustaintxt;
    public Text reputationtxt;

    public bool answered; // den här säger om man redan har svarat på ett event eller inte

    public bool eventYes; // ja till event

    public bool eventNo; // nej till event

    public bool eventActive;

     

    public void SavePlayer () 
    {
        SaveSystem.SavePlayer(this);
    }



    public void LoadPlayer() 
    {
        SaveData data = SaveSystem.LoadPlayer();

        reputation = data.reputation;
    }

    


    // Start is called before the first frame update
    void Start()
    {
        weekText.text = "Week: " + week;
        clickText.text = "Click: " + click;
        moneyttxt.text = "$: " + money;
        sustaintxt.text = "Sus: " + sustain;
        reputationtxt.text = "Reputation: " + reputation;

        money = 50;

        reputation = 43;

        sustain = 140;

        eventActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        weekText.text = "Week: " + week;
        clickText.text = "Click: " + click;
        moneyttxt.text = "$: " + money;
        sustaintxt.text = "Sus: " + sustain;
        reputationtxt.text = "Reputation: " + reputation;

        if (eventYes == true && week == 0) 
        {

            money = money + smallAmount;

            sustain = sustain - mediumAmount;

            eventActive = false;

            answered = true;

            eventYes = false;

        }

        if(eventNo == true && week == 0) 
        {

            eventActive = false;

            answered = true;

            eventNo = false;

        }
     

        //de här ser till att alla värden stannar inom 0-100, så att ser ut som procent

        if (money > 100)
        {
            money = 100;
        }

        if (money < 0)
        {
            money = 0;
        }

        if (sustain > 100)
        {
            sustain = 100;
        }

        if (sustain < 0)
        {
            sustain = 0;
        }

        if (reputation > 100)
        {
            reputation = 100;
        }

        if (reputation < 0)
        {
            reputation = 0;
        }
    }
}
