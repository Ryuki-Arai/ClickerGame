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
            count += DataManager.GetSkillLevel(2) * 15 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(3) * 200 * DataManager.Instance.Level;
            count += DataManager.GetSkillLevel(4) * 2500 * DataManager.Instance.Level;
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
    }
}
