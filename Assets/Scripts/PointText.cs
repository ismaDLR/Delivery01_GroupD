using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointText : MonoBehaviour
{
    public static Action<int> OnSendPoints;
    public static GameObject TextPoint;

    private void OnEnable()
    {
        Coin.OnSetPointText += SetPointsToText;
        PlayerCollision.OnDie += SendPoints;
    }

    private void OnDisable()
    {
        Coin.OnSetPointText -= SetPointsToText;
        PlayerCollision.OnDie -= SendPoints;
    }

    void Start()
    {
        TextPoint = GameObject.FindGameObjectWithTag("TextCoin");
        var value = 0;
        TextPoint.GetComponent<TMP_Text>().text = value.ToString();
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

    private void SendPoints()
    {
        OnSendPoints?.Invoke(int.Parse(TextPoint.GetComponent<TMP_Text>().text));
    }
}
