using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    int count;

    void Start()
    {
        _text.GetComponent<TextMeshProUGUI>();
    }

    public void Click()
    {
        count++;
        _text.text = $"Click : {count}";
    }
}
