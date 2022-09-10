using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
    [SerializeField] Button[] _button;
    float _time;
    float count;

    void Update()
    {
        _time += Time.deltaTime;
        if(_time >= 1f)
        {
            count += DataManager.GetSkillLevel(0) * 0.1f * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(1) * 1 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(2) * 10 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(3) * 100 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(4) * 1000 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(5) * 10000 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(6) * 100000 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(7) * 1000000 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(8) * 10000000 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(9) * 100000000 * DataManager.Instance.Level;
            var integer = Mathf.Floor(count);
            DataManager.Instance.Count += (BigInteger)integer;
            count -= integer;
            _time = 0f;
        }
        for(var i = 0; i < _button.Length; i++)
        {
            if(LevelUP.GetCost(DataManager.GetSkillLevel(i),i) > DataManager.Instance.Count)
            {
                _button[i].GetComponent<Button>().interactable = false;
            }
            else _button[i].GetComponent<Button>().interactable = true;
        }
        DataManager.Save();
    }
}
