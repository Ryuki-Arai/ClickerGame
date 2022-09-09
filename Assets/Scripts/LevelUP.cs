using UnityEngine;
using TMPro;
using System.IO;
using System;
using System.Collections.Generic;
using System.Numerics;

public class LevelUP : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI button0;
    [SerializeField] TextMeshProUGUI button1;
    [SerializeField] TextMeshProUGUI button2;
    [SerializeField] TextMeshProUGUI button3;
    [SerializeField] TextMeshProUGUI button4;
    [SerializeField] TextAsset _lebeluptable;
    [SerializeField] TextAsset _skillcost;
    ulong[] dummy = {10,100,1000,10000,100000};
    static List<ulong[]> skill_Cost = new List<ulong[]>();
    float _time;

    private void Awake()
    {
        DataManager.Load();
        LevelTable.LoadFile(_lebeluptable.name);
        LoadFile(_skillcost.name);
    }
    
    private void Start()
    {
        button0.GetComponent<TextMeshProUGUI>();
        button0.text = $"ícéq\nLevel{DataManager.GetSkillLevel(0)}\néü:{GetCost(DataManager.GetSkillLevel(0), 0).ToString("N0")}";
        button1.GetComponent<TextMeshProUGUI>();
        button1.text = $"Ç∑Ç∑Ç´\nLevel{DataManager.GetSkillLevel(1)}\néü:{GetCost(DataManager.GetSkillLevel(1), 1).ToString("N0")}";
        button2.GetComponent<TextMeshProUGUI>();
        button2.text = $"îu\nLevel{DataManager.GetSkillLevel(2)}\néü:{GetCost(DataManager.GetSkillLevel(2), 2).ToString("N0")}";
        button3.GetComponent<TextMeshProUGUI>();
        button3.text = $"ìe\nLevel{DataManager.GetSkillLevel(3)}\néü:{GetCost(DataManager.GetSkillLevel(3), 3).ToString("N0")}";
        button4.GetComponent<TextMeshProUGUI>();
        button4.text = $"åé…êŒ\nLevel{DataManager.GetSkillLevel(4)}\néü:{GetCost(DataManager.GetSkillLevel(4), 4).ToString("N0")}";
    }

    public void OnButton0Clecked()
    {
        if(DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(0), 0))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(0), 0);
            DataManager.SetSkillLevel(0);
            button0.text = $"ícéq\nLevel{DataManager.GetSkillLevel(0)}\néü:{Numeral.Numelal(GetCost(DataManager.GetSkillLevel(0), 0))}";
        }
        
    }

    public void OnButton1Clecked()
    {
        if(DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(1), 1))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(1), 1);
            DataManager.SetSkillLevel(1);
            button1.text = $"Ç∑Ç∑Ç´\nLevel{DataManager.GetSkillLevel(1)}\néü:{Numeral.Numelal(GetCost(DataManager.GetSkillLevel(1), 1))}";
        }
    }

    public void OnButton2Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(2), 2))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(2), 2);
            DataManager.SetSkillLevel(2);
            button2.text = $"îu\nLevel{DataManager.GetSkillLevel(2)}\néü:{Numeral.Numelal(GetCost(DataManager.GetSkillLevel(2), 2))}";
        }
    }

    public void OnButton3Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(3), 3))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(3), 3);
            DataManager.SetSkillLevel(3);
            button3.text = $"ìe\nLevel{DataManager.GetSkillLevel(3)}\néü:{Numeral.Numelal(GetCost(DataManager.GetSkillLevel(3), 3))}";
        }
    }

    public void OnButton4Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(4), 4))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(4), 4);
            DataManager.SetSkillLevel(4);
            button4.text = $"åéÇÃêŒ\nLevel{DataManager.GetSkillLevel(4)}\néü:{Numeral.Numelal(GetCost(DataManager.GetSkillLevel(4), 4))}";
        }
    }

    static public BigInteger GetCost(int _iskey, int _index)
    {
        BigInteger next_exp;
        try
        {
            next_exp = skill_Cost[_iskey][_index];
        }
        catch (ArgumentOutOfRangeException)
        {
            next_exp = skill_Cost[skill_Cost.Count-1][_index];
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
            Debug.LogError($"ÉtÉ@ÉCÉãÇì«Ç›çûÇﬂÇ‹ÇπÇÒ:{e.Message}");
            skill_Cost.Add(dummy);
        }
        catch (NullReferenceException e)
        {
            Debug.LogError($"ÉtÉ@ÉCÉãÇ™å©Ç¬Ç©ÇËÇ‹ÇπÇÒ:{e.Message}");
            skill_Cost.Add(dummy);
        }
        catch (ArgumentException)
        {
            return;
        }
    }
}
