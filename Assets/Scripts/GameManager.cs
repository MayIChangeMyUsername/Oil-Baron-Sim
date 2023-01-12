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

    public Text dateText;


    // Start is called before the first frame update
    void Start()
    {
        dateText.text = "Week: " + week;

         money = 56;

    sustain = 43;

   reputation = 23;
}

    // Update is called once per frame
    void Update()
    {
        dateText.text = "Week: " + week;

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
