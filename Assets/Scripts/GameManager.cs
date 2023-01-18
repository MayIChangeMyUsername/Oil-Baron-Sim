using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


   public int money;

   public int sustain;

   public int reputation;

    public int eventArrayNumber;

    string[] yesEffectArray = new string[] { "money = money - smallAmount reputation = reputation + smallAmount" };

    string[] noEffectArray = new string[] { "" };

    int fiftyFifty;

    // olika mängder som ändrar på tex money värdet i event
    int smallAmount = 5; 

    int mediumAmount = 10;

    int largeAmount = 20;

    public static int week = 0;
    public static int click = 1;

    public static bool clicki = true;

    public Text weekText;
    //public Text clickText;
    public Text moneyttxt;
    public Text sustaintxt;
    public Text reputationtxt;

    

    public bool eventYes; // ja till event

    public bool eventNo; // nej till event

    public bool eventActive; // är ett event igång

     

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
        //clickText.text = "Click: " + click;
        moneyttxt.text = "" + money;
        sustaintxt.text = "" + sustain;
        reputationtxt.text = "" + reputation;

        money = 50;

        reputation = 50;

        sustain = 50;

        eventActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        


        weekText.text = "Week: " + week;
        //clickText.text = "Click: " + click;
        moneyttxt.text = "" + money;
        sustaintxt.text = "" + sustain;
        reputationtxt.text = "" + reputation;

        if (eventYes == true) 
        {
            eventActive = false;



            eventYes = false;

            if (eventArrayNumber == 0) 
            {
                money = money - smallAmount;
                reputation = reputation + smallAmount;
            }
            if (eventArrayNumber == 1)
            {
                money = money + mediumAmount;
                sustain = sustain - mediumAmount;
            }
            if (eventArrayNumber == 2)
            {
                money = money - largeAmount;
            }
            if (eventArrayNumber == 3)
            {
                reputation = reputation - smallAmount;
            }
            if (eventArrayNumber == 4)
            {
                sustain = sustain - mediumAmount;
            }
            if (eventArrayNumber == 5)
            {
                money = money + mediumAmount;
                sustain = sustain - smallAmount;
            }
            if (eventArrayNumber == 6)
            {
                money = money - smallAmount;
                reputation = reputation + mediumAmount;
            }
            if (eventArrayNumber == 7)
            {
                
                money = money + smallAmount;
            }
            if (eventArrayNumber == 8)
            {
                money = money + smallAmount;
                reputation = reputation + smallAmount;
                sustain = sustain - mediumAmount;
            }
            if (eventArrayNumber == 9)
            {
                fiftyFifty = Random.Range(0, 1);

                if (fiftyFifty == 0) 
                { 
                    money = money - mediumAmount; 
                }
                else 
                {
                    money = money + mediumAmount;
                }

            }
            if (eventArrayNumber == 10)
            {
                reputation = reputation - mediumAmount;
            }
            if (eventArrayNumber == 11)
            {
                money = money - mediumAmount;
                sustain = sustain + smallAmount;
            }
            if (eventArrayNumber == 12)
            {
                money = money - mediumAmount;
               
            }
            if (eventArrayNumber == 13)
            {
                reputation = reputation + mediumAmount; //no more decisions from shop
            }
           
            if (eventArrayNumber == 14)
            {
                fiftyFifty = Random.Range(0, 1);
                if(fiftyFifty == 0) 
                {
                    money = money - smallAmount;
                    reputation = reputation + largeAmount;
                }
                else 
                {
                    money = money - smallAmount;
                    reputation = reputation - largeAmount;
                }
            }
            if (eventArrayNumber == 15)
            {
                money = money + largeAmount;
            }
            if (eventArrayNumber == 16)
            {
                money = money - mediumAmount;
                reputation = reputation + largeAmount;
                sustain = sustain + smallAmount;
            }
            if (eventArrayNumber == 17)
            {
                money = money - mediumAmount;
                reputation = reputation - smallAmount;

            }
        


        }

        if(eventNo == true) 
        {

            eventActive = false;
         
            eventNo = false;

            if (eventArrayNumber == 0)
            {
                money = money + smallAmount;
                reputation = reputation - smallAmount;
            }
            if (eventArrayNumber == 1)
            {
                reputation = reputation + smallAmount;
            }
            if (eventArrayNumber == 2)
            {
                money = money - largeAmount;
            }
            if (eventArrayNumber == 3)
            {
                
            }
            if (eventArrayNumber == 4)
            {

            }
            if (eventArrayNumber == 5)
            {

            }
            if (eventArrayNumber == 6)
            {

            }
            if (eventArrayNumber == 7)
            {

            }
            if (eventArrayNumber == 8)
            {

            }
            if (eventArrayNumber == 9)
            {

            }
            if (eventArrayNumber == 10)
            {

            }
            if (eventArrayNumber == 11)
            {

            }
            if (eventArrayNumber == 12)
            {

            }
            if (eventArrayNumber == 13)
            {

            }
            if (eventArrayNumber == 0)
            {

            }
            if (eventArrayNumber == 14)
            {

            }
            if (eventArrayNumber == 15)
            {

            }
            if (eventArrayNumber == 16)
            {

            }
            if (eventArrayNumber == 17)
            {

            }
            

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

    bool gameHasEnded = false;

    public float endScreenDelay = 1f;
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("EndScreen", endScreenDelay); //byter scene till EndScreen efter 1f (1f är tid)
        }
            
    }
    void EndScreen () //Behövs inte tills vi har lagt till end scenes.
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); //byter till end scenen efter vi har lagt till ett namn till den scenen. Name = Scen namn
    }
}
