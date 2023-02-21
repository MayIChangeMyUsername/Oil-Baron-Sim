
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveSystem //Axel
    //Jag �r lite os�ker p� vad allt det h�r g�r men jag tror den konverterar v�rden p� alla variabler i SaveData scriptet till binary
    //vid SavePlayer() och konverterar fr�n binary vid LoadPlayer()
{
    public static void SavePlayer (GameManager player ) 
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/savedata.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData(player);

        formatter.Serialize(stream, data);    
        stream.Close();
    }

    

    public static SaveData LoadPlayer() 
    {
        string path = Application.persistentDataPath + "/savedata.save";
        if (File.Exists(path)) 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

           SaveData data = formatter.Deserialize(stream) as SaveData;
            stream.Close();
            
            return data;
            
        } else
        {
            Debug.LogError("Save file not found" + path);
            return null;
        }
    }
}
