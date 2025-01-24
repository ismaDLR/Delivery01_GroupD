using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointText : MonoBehaviour
{

    void Start()
    {
        Coin.OnSetPointText += SetPointsToText;
    }

    void Update()
    {

    }

    private void SetPointsToText(int number)
    {
        var numberOfPoints = int.Parse(GetComponent<TMP_Text>().text) + number;
        GetComponent<TMP_Text>().text = numberOfPoints.ToString();
    }
}
