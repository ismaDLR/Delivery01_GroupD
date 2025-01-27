using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<TMP_Text>().text = DataManager.Points.ToString();
    }
}
