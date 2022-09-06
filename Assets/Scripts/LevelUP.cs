using UnityEngine;
using TMPro;
using System.IO;
using System;
using System.Collections.Generic;

public class LevelUP : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI button0;
    [SerializeField] TextMeshProUGUI button1;
    [SerializeField] TextMeshProUGUI button2;
    [SerializeField] TextMeshProUGUI button3;
    [SerializeField] TextMeshProUGUI button4;
    [SerializeField] TextAsset _lebeluptable;
    [SerializeField] TextAsset _skillcost;
    static int[] skill_Level = new int[5];
    ulong[] dummy = {10,100,1000,10000,100000};
    List<ulong[]> skill_Cost = new List<ulong[]>();
    float _time;

    static public int Skill_Level(int index)
    {
        return skill_Level[index];
    }

    private void Awake()
    {
        LevelTable.LoadFile(_lebeluptable.name);
        LoadFile(_skillcost.name);
    }

    private void Start()
    {
        button0.GetComponent<TextMeshProUGUI>();
        button0.text = $"0\nLevel{skill_Level[0]}";
        button1.GetComponent<TextMeshProUGUI>();
        button1.text = $"1\nLevel{skill_Level[1]}";
        button2.GetComponent<TextMeshProUGUI>();
        button2.text = $"2\nLevel{skill_Level[2]}";
        button3.GetComponent<TextMeshProUGUI>();
        button3.text = $"3\nLevel{skill_Level[3]}";
        button4.GetComponent<TextMeshProUGUI>();
        button4.text = $"4\nLevel{skill_Level[4]}";
    }

    public void OnButton0Clecked()
    {
        if(DataManager.Instance.Count >= GetCost(skill_Level[0], 0))
        {
            DataManager.Instance.Count -= GetCost(skill_Level[0], 0);
            skill_Level[0]++;
            button0.text = $"0\nLevel{skill_Level[0]}";
        }
        
    }

    public void OnButton1Clecked()
    {
        if(DataManager.Instance.Count >= GetCost(skill_Level[1], 1))
        {
            DataManager.Instance.Count -= GetCost(skill_Level[1], 1);
            skill_Level[1]++;
            button1.text = $"1\nLevel{skill_Level[1]}";
        }
    }

    public void OnButton2Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(skill_Level[2], 2))
        {
            DataManager.Instance.Count -= GetCost(skill_Level[2], 2);
            skill_Level[2]++;
            button2.text = $"2\nLevel{skill_Level[2]}";
        }
    }

    public void OnButton3Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(skill_Level[3], 3))
        {
            DataManager.Instance.Count -= GetCost(skill_Level[3], 3);
            skill_Level[3]++;
            button3.text = $"3\nLevel{skill_Level[3]}";
        }
    }

    public void OnButton4Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(skill_Level[4], 4))
        {
            DataManager.Instance.Count -= GetCost(skill_Level[4], 4);
            skill_Level[4]++;
            button4.text = $"4\nLevel{skill_Level[4]}";
        }
    }

    public ulong GetCost(int _iskey, int _index)
    {
        ulong next_exp;
        try
        {
            next_exp = skill_Cost[_iskey][_index];
        }
        catch (KeyNotFoundException)
        {
            next_exp = skill_Cost[skill_Cost.Count][_index];
        }
        return next_exp;
    }

    public void LoadFile(string _filepath)
    {
        try
        {
            var _file = Resources.Load<TextAsset>(_filepath);
            StringReader _sr = new StringReader(_file.text);
            string line;
            while ((line = _sr.ReadLine()) != null)
            {
                var data = line.Split(',');
                var dArray = new ulong[data.Length];
                for(var i = 0; i < dArray.Length; i++)
                {
                    dArray[i] = ulong.Parse(data[i]);
                }
                skill_Cost.Add(dArray);
            }
            _sr.Close();
        }
        catch (IOException e)
        {
            Debug.LogError($"ファイルを読み込めません:{e.Message}");
            skill_Cost.Add(dummy);
        }
        catch (NullReferenceException e)
        {
            Debug.LogError($"ファイルが見つかりません:{e.Message}");
            skill_Cost.Add(dummy);
        }
        catch (ArgumentException)
        {
            return;
        }
    }
}
