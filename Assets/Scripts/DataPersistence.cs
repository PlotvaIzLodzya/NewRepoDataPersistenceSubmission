using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence Instance;
    public string playerName;
    public string bestPlayer;
    public int score;


    // Start is called before the first frame update
    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    class SaveData
    {
        public string playerName;
        public string bestPlayer;
        public int score;
    }

    public void SaveName()
    {
        SaveData saveData = new SaveData();
        saveData.bestPlayer = bestPlayer;

        saveData.score = score;
         
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);

            bestPlayer = saveData.bestPlayer;
            score = saveData.score;
        }
    }
}


