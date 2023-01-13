using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   public int money;

   public int sustain;

   public int reputation;

    public static int week = 0;
    public static int click = 1;

    public Text weekText;
    public Text clickText;

    // Start is called before the first frame update
    void Start()
    {
        weekText.text = "Week: " + week;
        clickText.text = "Click: " + click;

        money = 50;

        reputation = 43;

        sustain = 140;
         
}

    // Update is called once per frame
    void Update()
    {
        weekText.text = "Week: " + week;
        clickText.text = "Click: " + click;

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
