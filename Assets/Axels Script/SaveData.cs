using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SaveData
{
    public int Money;
    public int reputation;
    public int sustain;
    public int week;
    public int currentEventNum;


    public SaveData (GameManager player ) 
    {
        reputation = player.reputation;
        sustain = player.sustain;
        Money = player.money;
        week = player.week;
        //currentEventNum = player.FindObjectOfType<SkipdayLockTest>().nextEventNumber;


    }

    
        
}
