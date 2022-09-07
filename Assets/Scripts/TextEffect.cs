using System.Numerics;
using TMPro;
using UnityEngine;

public class TextEffect : MonoBehaviour
{
    TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        var count = Mathf.Pow(2,DataManager.Instance.Level-1);
        DataManager.Instance.Count += (BigInteger)(count);
        text.text = $"+{count.ToString("N0")}" ;
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
