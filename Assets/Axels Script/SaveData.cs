using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SaveData //Gjort av Axel förutom där det står Elliot
{
    public int Money;
    public int reputation;
    public int sustain;
    public int week;
    public int eventArrayNumber; //Elliot


    public SaveData (GameManager player ) 
    {
        reputation = player.reputation;
        sustain = player.sustain;
        Money = player.money;
        week = player.week;
        eventArrayNumber = player.eventArrayNumber; //Elliot


    }

    
        
}
