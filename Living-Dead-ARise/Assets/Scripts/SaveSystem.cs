using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SavePersonalBest(int score, DateTime date)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/personalBest.bin";
        FileStream stream = new FileStream(path, FileMode.Create);

        PersonalBestData data = new PersonalBestData(score, date);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PersonalBestData LoadPersonalBest()
    {
        string path = Application.persistentDataPath + "/personalBest.bin";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PersonalBestData data = formatter.Deserialize(stream) as PersonalBestData;
            stream.Close();
            return data;
        } else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
