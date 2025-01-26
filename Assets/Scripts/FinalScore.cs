using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PointText.OnEndingPoints += SetPointText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetPointText(int number)
    {
        gameObject.GetComponent<TMP_Text>().text = number.ToString();
    }
}
