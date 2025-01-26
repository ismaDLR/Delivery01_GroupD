using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<TMP_Text>().text = PointText.TextPoint.GetComponent<TMP_Text>().text;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
