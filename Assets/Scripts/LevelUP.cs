using UnityEngine;
using TMPro;

public class LevelUP : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI button1;
    [SerializeField] TextMeshProUGUI button2;
    [SerializeField] TextMeshProUGUI button3;
    [SerializeField] TextMeshProUGUI button4;
    [SerializeField] TextAsset _lebeluptable;

    private void Awake()
    {
        LevelTable.LoadFile(_lebeluptable.name);
    }

    public void OnButton1Clecked()
    {

    }

    public void OnButton2Clecked()
    {

    }

    public void OnButton3Clecked()
    {

    }

    public void OnButton4Clecked()
    {

    }
}
