using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public static int points;

    private void OnEnable()
    {
        PointText.OnSendPoints += GetSendPoints;
    }

    private void OnDisable()
    {
        PointText.OnSendPoints -= GetSendPoints;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetSendPoints(int number)
    {
        points = number;
    }
}
