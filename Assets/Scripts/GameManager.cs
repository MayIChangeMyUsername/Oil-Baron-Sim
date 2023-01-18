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

        if (eventYes == true && week == 0) 
        {

            money = money + smallAmount;

            sustain = sustain - mediumAmount;

            eventActive = false;

            

            eventYes = false;

        }

        if(eventNo == true && week == 0) 
        {

            sustain = sustain + largeAmount;

            eventActive = false;

            

            eventNo = false;

        }

        if (eventYes == true && week > 0)
        {

            money = money + mediumAmount;

            reputation = reputation- smallAmount;

            eventActive = false;



            eventYes = false;

        }

        if (eventNo == true && week > 0)
        {

            sustain = sustain + mediumAmount;

            eventActive = false;



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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //byter till end scenen efter vi har lagt till ett namn till den scenen. Name = Scen namn
    }
}
