using TMPro;
using UnityEngine;

public class TextEffect : MonoBehaviour
{
    TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        var count = DataManager.Instance.Level;
        DataManager.Instance.Count += (ulong)(count);
        text.text = $"+{count.ToString("N0")}" ;
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
