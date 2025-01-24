using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Action<int> OnSetPointText;

    [SerializeField]
    private int points;

    void Start()
    {
        PlayerCollision.OnGetCoin += SendToPointText;
    }


    void Update()
    {
        
    }

    private void SendToPointText()
    {
        OnSetPointText?.Invoke(points);
        Destroy(gameObject);
    }
}
