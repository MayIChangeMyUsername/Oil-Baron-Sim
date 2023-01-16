using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
   public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }


    public void LoadPlayer()
    {
        //SaveData data = SaveSystem.LoadPlayer();

        //reputation = data.reputation;
    }
    
}
