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
    }

    public void Click()
    {
        Instantiate(_effect_Text,transform);
        DataManager.Instance.Count++;
        _slider.value++;
        _counter_Text.text = $"{DataManager.Instance.Count.ToString("N0")}";
    }
}
