using System.Numerics;
using TMPro;
using UnityEngine;

public class TextEffect : MonoBehaviour
{
    TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        var count = Numeral.Pow(2,DataManager.Instance.Level-1);
        DataManager.Instance.Count += (count);
        text.text = $"+{Numeral.Numeration(count)}" ;
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
