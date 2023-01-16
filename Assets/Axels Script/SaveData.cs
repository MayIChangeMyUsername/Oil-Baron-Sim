using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SaveData : MonoBehaviour
{
    public int Money;
    public int reputation;
    public int sustain; 


    public SaveData (GameManager player ) 
    {
        reputation = player.reputation;
        sustain = player.sustain;
        Money = player.money;
     
    }   
        
}
