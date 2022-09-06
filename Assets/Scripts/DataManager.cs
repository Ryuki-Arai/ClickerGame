using UnityEngine;

public class DataManager
{
    static DataManager _instance = new DataManager();
    public static DataManager Instance => _instance;
    DataManager() { }

    int level = PlayerPrefs.GetInt("Level", 1);
    public int Level
    {
        get => level;
        set => level = value;
    }

    ulong count = ulong.Parse(PlayerPrefs.GetString("Count", "0"));
    public ulong Count
    {
        get => count;
        set => count = value;
    }

    public void Load()
    {
        level = PlayerPrefs.GetInt("Level",1);
        count = ulong.Parse(PlayerPrefs.GetString("Count","0"));
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.SetString("Count",count.ToString());
        PlayerPrefs.Save();
    }
}
