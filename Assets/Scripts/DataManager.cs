using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager
{
    static DataManager _instance = new DataManager();
    public static DataManager Instance => _instance;
    DataManager() { }

    int level = 1;
    public int Level
    {
        get => level;
        set => level = value;
    }

    ulong count = 0;
    public ulong Count
    {
        get => count;
        set => count = value;
    }

    public void Load()
    {
        level = PlayerPrefs.GetInt("Level");
        count = ulong.Parse(PlayerPrefs.GetString("Count"));
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.SetString("Count",count.ToString());
        PlayerPrefs.Save();
    }
}
