using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI highScoreText;


    public int money; // hur mycket pengar du har (Elliot)

    public int sustain; // hur mycket sustainability du har (Elliot)

    public int reputation; // hur mycket reputation du har (Elliot)

    public int eventArrayNumber; //nummer på eventet som visas

    public float endScreenDelay = 0.1f;

    int fiftyFifty; // används till vissa event (Elliot)

    // olika mängder som ändrar på tex money värdet i event (Elliot)
    int smallAmount = 15;

    int mediumAmount = 30;

    int largeAmount = 45;

    public int week = 0;
    public static int click = 1;

    public static bool clicki = true; // gammal test variabel (Anton)

    public Text weekText;
    //public Text clickText;
    public Text moneyttxt;
    public Text sustaintxt;
    public Text reputationtxt;



    public bool eventYes; // ja till event

    public bool eventNo; // nej till event

    public bool eventActive; // är ett event igång


    
    public void SavePlayer() //sätts igång när man går till nästa vecka, genom skipdaylocktest skriptet
    {
        
        
        
            SaveSystem.SavePlayer(this); //Axel




    }



    public void LoadPlayer() //Axel
    {
        SaveData data = SaveSystem.LoadPlayer(); //Axel

        week = data.week; //Axel
        money = data.Money; //Axel
        reputation = data.reputation; //Axel
        sustain = data.sustain; //Axel
        eventArrayNumber = data.eventArrayNumber; //elliot

    }







    // Start is called before the first frame update
    void Start()
    {
        weekText.text = "Week " + week;
        //clickText.text = "Click: " + click;
        moneyttxt.text = "" + money;
        sustaintxt.text = "" + sustain;
        reputationtxt.text = "" + reputation;

        money = 50; //(Elliot)

        reputation = 50; //(Elliot)

        sustain = 50; //(Elliot)

        UpdateHighScore();

    }

    // Update is called once per frame
    void Update()
    {



        weekText.text = "Week " + week;
        CheckHighScore();
        //clickText.text = "Click: " + click;
        moneyttxt.text = "" + money;
        sustaintxt.text = "" + sustain;
        reputationtxt.text = "" + reputation;

        if (eventYes == true) //det här och nedanför ändrar på stats om man trycker ja, olika mycket beroende på event (Elliot)
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
            if (eventArrayNumber == 3)// bad rumours
            {
                reputation = reputation - smallAmount;
                money = money - smallAmount;
            }
            if (eventArrayNumber == 4) //oil leak
            {
                sustain = sustain - mediumAmount;
                money = money - smallAmount;
            }
            if (eventArrayNumber == 5) //oil consumption 
            {
                money = money + mediumAmount;
                reputation = reputation + smallAmount;
                sustain = sustain - smallAmount;
            }
            if (eventArrayNumber == 6) // social media
            {
                money = money - smallAmount;
                reputation = reputation + largeAmount;
            }
            if (eventArrayNumber == 7) // effective extraction
            {
                sustain = sustain - smallAmount;
                money = money + mediumAmount;
            }
            if (eventArrayNumber == 8) // oil demand
            {
                money = money + smallAmount;
                reputation = reputation + smallAmount;
                sustain = sustain - mediumAmount;
            }
            if (eventArrayNumber == 9) //swindler
            {
                fiftyFifty = Random.Range(0, 2);

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
                reputation = reputation + smallAmount;
                money = money - smallAmount;
            }

            if (eventArrayNumber == 14)//large spillage
            {
                money = money - smallAmount;
                fiftyFifty = Random.Range(0, 2);
                if (fiftyFifty == 0)
                {
                    
                    reputation = reputation - largeAmount;
                }
                else
                {
                    
                    reputation = reputation + largeAmount;
                }
            }
            if (eventArrayNumber == 15)//subsidise
            {
                money = money + mediumAmount;
                reputation = reputation + smallAmount;
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

        if (eventNo == true) //det här och nedanför ändrar på stats om man trycker nej, olika mycket beroende på event //(Elliot)
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
            if (eventArrayNumber == 3) // bad rumours
            {
                reputation = reputation - mediumAmount;
            }
            if (eventArrayNumber == 4)// oil leak
            {
                sustain = sustain - mediumAmount;
                reputation = reputation - mediumAmount;
            }
            if (eventArrayNumber == 5) // oil consumption
            {
                money = money + largeAmount;

                sustain = sustain - smallAmount;
            }
            if (eventArrayNumber == 6) // social media
            {
                reputation = reputation + mediumAmount;
            }
            if (eventArrayNumber == 7) // effective extraction
            {
                reputation = reputation + smallAmount;
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
                
                
            }

            if (eventArrayNumber == 14)// big spillage
            {
                reputation = reputation - largeAmount;
            }
            if (eventArrayNumber == 15)//subsidies
            {
                sustain = sustain + mediumAmount;
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





        //de här ser till att alla värden stannar inom 0-100, så att är som procent //(Elliot)

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



        // om man förlorar tas man till rätt end screen
        if (money == 0)
        {
            ResetSave();
            Invoke("EndScreen", endScreenDelay);


        }
        if (reputation == 0)
        {
            ResetSave();
            Invoke("EndScreen1", endScreenDelay);
           
        }
        if (sustain == 0)
        {
            ResetSave();
            Invoke("EndScreen2", endScreenDelay);
            
        }


    }

    void ResetSave() //Elliot och Axel
    {

        PlayerPrefs.SetInt("week", week); //sparar veckonummret man förlorade på - Elliot

        money = 50;
        sustain = 50;
        reputation = 50;
        week = 1;
        FindObjectOfType<SkipdayLockTest>().RollEventDice();
        SavePlayer();

    }

   

    


    void CheckHighScore() // Skapar en fil inom din dator som sparar ditt higscore du fått egenom din senaste playthrough (Anton)
    {
        if(week > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", week);
        }
    }

    void UpdateHighScore() // Updaterar det highscoret du fått genom din senaste playthrough (Anton)
    {
        highScoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }

    void EndScreen() //Behövs inte tills vi har lagt till end scenes.
    {
        SceneManager.LoadScene("MoneyEnding"); //byter till end scenen efter vi har lagt till ett namn till den scenen. Name = Scen namn
        Debug.Log("Money");
    }
    void EndScreen1() //Behövs inte tills vi har lagt till end scenes.
    {
        SceneManager.LoadScene("ReputationEnding"); //byter till end scenen efter vi har lagt till ett namn till den scenen. Name = Scen namn
        Debug.Log("Rep");
    }
    void EndScreen2() //Behövs inte tills vi har lagt till end scenes.
    {
        SceneManager.LoadScene("SustainEnding"); //byter till end scenen efter vi har lagt till ett namn till den scenen. Name = Scen nam
        Debug.Log("Sus");
    }
}