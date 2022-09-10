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
    [SerializeField] TextMeshProUGUI button5;
    [SerializeField] TextMeshProUGUI button6;
    [SerializeField] TextMeshProUGUI button7;
    [SerializeField] TextMeshProUGUI button8;
    [SerializeField] TextMeshProUGUI button9;
    [SerializeField] TextAsset _lebeluptable;
    [SerializeField] TextAsset _skillcost;
    BigInteger[] dummy = {10,100,1000,10000,100000};
    static List<BigInteger[]> skill_Cost = new List<BigInteger[]>();
    static public int SkillCost => skill_Cost.Count;
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
        button0.text = $"ícéq:{DataManager.GetSkillLevel(0)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(0), 0))}";
        button1.GetComponent<TextMeshProUGUI>();
        button1.text = $"Ç∑Ç∑Ç´:{DataManager.GetSkillLevel(1)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(1), 1))}";
        button2.GetComponent<TextMeshProUGUI>();
        button2.text = $"îu:{DataManager.GetSkillLevel(2)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(2), 2))}";
        button3.GetComponent<TextMeshProUGUI>();
        button3.text = $"åéìe:{DataManager.GetSkillLevel(3)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(3), 3))}";
        button4.GetComponent<TextMeshProUGUI>();
        button4.text = $"åé…êŒ:{DataManager.GetSkillLevel(4)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(4), 4))}";
        button5.GetComponent<TextMeshProUGUI>();
        button5.text = $"åéâÿ:{DataManager.GetSkillLevel(5)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(5), 5))}";
        button6.GetComponent<TextMeshProUGUI>();
        button6.text = $"ÉAÉ|ÉçåvâÊ:{DataManager.GetSkillLevel(6)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(6), 6))}";
        button7.GetComponent<TextMeshProUGUI>();
        button7.text = $"ìV…âHàﬂ:{DataManager.GetSkillLevel(7)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(7), 7))}";
        button8.GetComponent<TextMeshProUGUI>();
        button8.text = $"åé…ìs:{DataManager.GetSkillLevel(8)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(8), 8))}";
        button9.GetComponent<TextMeshProUGUI>();
        button9.text = $"åéì¯:{DataManager.GetSkillLevel(9)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(9), 9))}";
    }

    public void OnButton0Clecked()
    {
        if(DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(0), 0))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(0), 0);
            DataManager.SetSkillLevel(0);
            button0.text = $"ícéq:{DataManager.GetSkillLevel(0)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(0), 0))}";
        }
        
    }

    public void OnButton1Clecked()
    {
        if(DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(1), 1))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(1), 1);
            DataManager.SetSkillLevel(1);
            button1.text = $"Ç∑Ç∑Ç´:{DataManager.GetSkillLevel(1)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(1), 1))}";
        }
    }

    public void OnButton2Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(2), 2))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(2), 2);
            DataManager.SetSkillLevel(2);
            button2.text = $"îu:{DataManager.GetSkillLevel(2)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(2), 2))}";
        }
    }

    public void OnButton3Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(3), 3))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(3), 3);
            DataManager.SetSkillLevel(3);
            button3.text = $"åéìe:{DataManager.GetSkillLevel(3)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(3), 3))}";
        }
    }

    public void OnButton4Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(4), 4))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(4), 4);
            DataManager.SetSkillLevel(4);
            button4.text = $"åéÇÃêŒ:{DataManager.GetSkillLevel(4)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(4), 4))}";
        }
    }

    public void OnButton5Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(5), 5))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(5), 5);
            DataManager.SetSkillLevel(5);
            button5.text = $"åéâÿ:{DataManager.GetSkillLevel(5)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(5), 5))}";
        }
    }

    public void OnButton6Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(6), 6))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(6), 6);
            DataManager.SetSkillLevel(6);
            button6.text = $"ÉAÉ|ÉçåvâÊ:{DataManager.GetSkillLevel(6)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(6), 6))}";
        }
    }

    public void OnButton7Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(7), 7))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(7), 7);
            DataManager.SetSkillLevel(7);
            button7.text = $"ìV…âHàﬂ:{DataManager.GetSkillLevel(7)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(7), 7))}";
        }
    }

    public void OnButton8Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(8), 8))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(8), 8);
            DataManager.SetSkillLevel(8);
            button8.text = $"åé…ìs:{DataManager.GetSkillLevel(8)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(8), 8))}";
        }
    }

    public void OnButton9Clecked()
    {
        if (DataManager.Instance.Count >= GetCost(DataManager.GetSkillLevel(9), 9))
        {
            DataManager.Instance.Count -= GetCost(DataManager.GetSkillLevel(9), 9);
            DataManager.SetSkillLevel(9);
            button9.text = $"åéì¯:{DataManager.GetSkillLevel(9)}\néü:{Numeral.Numeration(GetCost(DataManager.GetSkillLevel(9), 9))}";
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
                var dArray = new BigInteger[data.Length];
                for(var i = 0; i < dArray.Length; i++)
                {
                    dArray[i] = BigInteger.Parse(data[i]);
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
