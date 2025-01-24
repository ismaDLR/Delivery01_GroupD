using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Action<int> OnSetPointText;
    public int Points;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnSetPointText?.Invoke(Points);
            Destroy(gameObject);
        }
    }
}
