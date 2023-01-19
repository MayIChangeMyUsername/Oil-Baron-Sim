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

    public int eventArrayNumber; //nummer på eventet som visas

    

    int fiftyFifty; // används till vissa event

    // olika mängder som ändrar på tex money värdet i event
    int smallAmount = 15; 

    int mediumAmount = 30;

    int largeAmount = 45;

    public static int week = 0;
    public static int click = 1;

    public static bool clicki = true; // gammal test variabel

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

        
    }

    // Update is called once per frame
    void Update()
    {
        


        weekText.text = "Week: " + week;
        //clickText.text = "Click: " + click;
        moneyttxt.text = "" + money;
        sustaintxt.text = "" + sustain;
        reputationtxt.text = "" + reputation;

        if (eventYes == true) //det här ändrar på stats om man trycker ja
        {
            eventActive = false;

            eventYes = false;

            if (eventArrayNumber == 0) // lower prices
            {
                money = money - smallAmount;
                reputation = reputation + smallAmount;
            }
            if (eventArrayNumber == 1) // buy land
            {
                money = money + mediumAmount;
                sustain = sustain - mediumAmount;
            }
            if (eventArrayNumber == 2) // stock crash
            {
                money = money - mediumAmount;
                reputation = reputation - mediumAmount;
            }
            if (eventArrayNumber == 3)// bad rumours (bara ja)
            {
                reputation = reputation - smallAmount;
            }
            if (eventArrayNumber == 4) //oil leak
            {
                sustain = sustain - mediumAmount;
                money = money - smallAmount;
            }
            if (eventArrayNumber == 5) //oil consumption (bara ja)
            {
                money = money + mediumAmount;
                sustain = sustain - smallAmount;
            }
            if (eventArrayNumber == 6) // social media
            {
                money = money - smallAmount;
                reputation = reputation + largeAmount;
            }
            if (eventArrayNumber == 7) // effective extraction
            {
                
                money = money + smallAmount;
            }
            if (eventArrayNumber == 8) // oil demand
            {
                money = money + smallAmount;
                reputation = reputation + smallAmount;
                sustain = sustain - mediumAmount;
            }
            if (eventArrayNumber == 9) //swindler
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
            if (eventArrayNumber == 10) //protests
            {
                reputation = reputation - mediumAmount;
                money = money - smallAmount;
            }
            if (eventArrayNumber == 11)// oil rig repair
            {
                money = money - mediumAmount;
                sustain = sustain + smallAmount;
            }
            if (eventArrayNumber == 12)// sunk ship
            {
                money = money - mediumAmount;
               
            }
            if (eventArrayNumber == 13)// tour
            {
                reputation = reputation + mediumAmount; //no more decisions from shop
            }
           
            if (eventArrayNumber == 14)//large spillage
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
            if (eventArrayNumber == 15)//susidise
            {
                money = money + largeAmount;
            }
            if (eventArrayNumber == 16)//sustainable extraction
            {
                money = money - mediumAmount;
                reputation = reputation + largeAmount;
                sustain = sustain + smallAmount;
            }
            if (eventArrayNumber == 17)// hit piece
            {
                money = money - smallAmount;
                reputation = reputation - smallAmount;

            }
        


        }

        if(eventNo == true) //det här ändrar på stats om man trycker nej
        {

            eventActive = false;
         
            eventNo = false;

            if (eventArrayNumber == 0) //lower prices
            {
                money = money + smallAmount;
                reputation = reputation - smallAmount;
            }
            if (eventArrayNumber == 1) // buy land
            {
                reputation = reputation + smallAmount;
            }
            if (eventArrayNumber == 2) // stock crash
            {
                money = money - largeAmount;
            }
            if (eventArrayNumber == 3) // bad rumours (bara ja)
            {
                
            }
            if (eventArrayNumber == 4)// oil leak
            {
                sustain = sustain - mediumAmount;
                reputation = reputation -  mediumAmount;
            }
            if (eventArrayNumber == 5) // oil consumption (bara ja)
            {

            }
            if (eventArrayNumber == 6) // social media
            {
                reputation = reputation + mediumAmount;
            }
            if (eventArrayNumber == 7) // effective extraction (bara ja)
            {

            }
            if (eventArrayNumber == 8) //demand
            {
                money = money - mediumAmount;
                sustain = sustain + mediumAmount;
            }
            if (eventArrayNumber == 9)//swindler
            {
                //
            }
            if (eventArrayNumber == 10)// protests
            {
                reputation = reputation - largeAmount;
            }
            if (eventArrayNumber == 11)//rig repair
            {
                sustain = sustain - mediumAmount;
                reputation = reputation - smallAmount;
            }
            if (eventArrayNumber == 12) // sunk
            {
                reputation = reputation - mediumAmount;
                sustain = sustain - largeAmount;
            }
            if (eventArrayNumber == 13)//tour
            {
                reputation = reputation - smallAmount;
            }
           
            if (eventArrayNumber == 14)// big spillage
            {
                reputation = reputation - largeAmount;
            }
            if (eventArrayNumber == 15)//subsidies
            {
                reputation = reputation - mediumAmount;
            }
            if (eventArrayNumber == 16)//sustainable extraction
            {
                reputation = reputation - smallAmount;
            }
            if (eventArrayNumber == 17)//hit piece
            {
                reputation = reputation - mediumAmount;
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
