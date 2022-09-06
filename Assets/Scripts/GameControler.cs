using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _counter_Text;
    [SerializeField] TextMeshProUGUI _effect_Text;
    [SerializeField] TextMeshProUGUI _level_Text;
    [SerializeField] Slider _slider;

    void Start()
    {
        _counter_Text.GetComponent<TextMeshProUGUI>();
        _level_Text.GetComponent<TextMeshProUGUI>();
        _level_Text.text = $"Level:{DataManager.Instance.Level}";
        _slider.GetComponent<Slider>();
        _slider.value = 0;
        _slider.maxValue = LevelTable.GetEXP(DataManager.Instance.Level);
    }

    private void Update()
    {
        _counter_Text.text = DataManager.Instance.Count.ToString("N0");
    }

    public void Click()
    {
        Instantiate(_effect_Text,transform);
        _slider.value++;
        if(_slider.value >= _slider.maxValue)
        {
            DataManager.Instance.Level++;
            _level_Text.text = $"Level:{DataManager.Instance.Level}";
            _slider.value = 0;
            _slider.maxValue = LevelTable.GetEXP(DataManager.Instance.Level);
        }
    }
}
