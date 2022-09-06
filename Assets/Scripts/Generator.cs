using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    float _time;
    float count;

    void Update()
    {
        _time += Time.deltaTime;
        if(_time >= 1f)
        {
            count += LevelUP.Skill_Level(0) * 0.1f;
            count += LevelUP.Skill_Level(1) * 1;
            count += LevelUP.Skill_Level(2) * 3;
            count += LevelUP.Skill_Level(3) * 5;
            count += LevelUP.Skill_Level(4) * 10;
            var integer = Mathf.Floor(count);
            DataManager.Instance.Count += (ulong)integer;
            count -= integer;
            _time = 0f;
        }
    }
}
