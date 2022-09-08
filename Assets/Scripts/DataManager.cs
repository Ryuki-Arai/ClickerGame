using System.Numerics;
using UnityEngine;

public class DataManager
{
    static DataManager _instance = new DataManager();
    public static DataManager Instance => _instance;
    DataManager() { }

    static int level = 1;
    public int Level
    {
        get => level;
        set => level = value;
    }

    static BigInteger count = 1;
    public BigInteger Count
    {
        get => count;
        set => count = value;
    }

    static int[] skill_Level = new int[5];
    static public int GetSkillLevel(int index)
    {
        return skill_Level[index];
    }
    static public void SetSkillLevel(int index)
    {
        skill_Level[index]++;
    }

    static public void Load()
    {
        level = PlayerPrefs.GetInt("Level",1);
        count = BigInteger.Parse(PlayerPrefs.GetString("Count", "0"));
        for(int i = 0; i < skill_Level.Length; i++)
        {
            skill_Level[i] = PlayerPrefs.GetInt($"Skill{i}",0);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.SetString("Count",count.ToString());
        for (int i = 0; i < skill_Level.Length; i++)
        {
            PlayerPrefs.SetInt($"Skill{i}", skill_Level[i]);
        }
        PlayerPrefs.Save();
    }
}
