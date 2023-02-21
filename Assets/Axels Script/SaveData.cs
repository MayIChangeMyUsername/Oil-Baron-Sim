using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SaveData //Gjort av Axel f�rutom d�r det st�r Elliot
    //sparar variabler fr�n GameManager f�r att sedan l�ta dem anv�ndas i SaveSystem scriptet
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
