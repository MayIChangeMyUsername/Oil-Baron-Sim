
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveSystem
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
