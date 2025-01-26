using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointText : MonoBehaviour
{
    public static Action<int> OnEndingPoints;
    private GameObject TextPoint;
    void Start()
    {
        Coin.OnSetPointText += SetPointsToText;
        PlayerCollision.OnDie += SetEndingPoints;
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

    private void SetEndingPoints()
    {
        Debug.Log("b");
        Debug.Log(TextPoint.GetComponent<TMP_Text>().text);
        OnEndingPoints?.Invoke(int.Parse(TextPoint.GetComponent<TMP_Text>().text));
    }
}
