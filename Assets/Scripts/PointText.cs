using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointText : MonoBehaviour
{
    public static GameObject TextPoint;
    void Start()
    {
        Coin.OnSetPointText += SetPointsToText;
        TextPoint = GameObject.FindGameObjectWithTag("TextCoin");
    }

    void Update()
    {

    }

    private void SetPointsToText(int number)
    {
        var numberOfPoints = int.Parse(TextPoint.GetComponent<TMP_Text>().text) + number;
        //var numberOfPoints = int.Parse(GetComponent<TMP_Text>().text) + number;
        TextPoint.GetComponent<TMP_Text>().text = numberOfPoints.ToString();
    }
}
