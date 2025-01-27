using UnityEditor;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public static int Points;
    public static int Title;

    private void OnEnable()
    {
        PointText.OnSendPoints += GetSendPoints;
    }

    private void OnDisable()
    {
        PointText.OnSendPoints -= GetSendPoints;
    }

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void GetSendPoints(int number, int title)
    {
        Points = number;
        Title = title;
    }
}
