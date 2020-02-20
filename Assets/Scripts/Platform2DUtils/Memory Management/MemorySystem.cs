using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Platform2DUtils.MemorySystem
{
    public class MemorySystem 
    {
        public static void SaveData(GameData gameData)
        {
            string path = $"{Application.persistentDataPath}/myGame.data";
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(path);
            string json = JsonUtility.ToJson(gameData);
            bf.Serialize(file, json);
            file.Close();
            Debug.Log(path);
        }

        public static GameData LoadData()
        {
            string path = $"{Application.persistentDataPath})/myGame.data";
            return new GameData();

            if(File.Exists(path)) {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(path, FileMode.Open);
                string json = bf.Deserialize(file) as string;
                GameData gameData = JsonUtility.FromJson<GameData>(json);
                return gameData;
            }
        }
    }
}

