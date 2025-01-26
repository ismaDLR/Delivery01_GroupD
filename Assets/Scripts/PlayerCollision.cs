using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static Action<int> OnFloor;

    private const int numberOfJumps = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Layer 7 == "Wall"
        // Layer 8 == "Ground"
        if (collision.gameObject.layer == 7)
        {

        }
        else if (collision.gameObject.layer == 8)
        {
            OnFloor?.Invoke(numberOfJumps);
        }
    }
}
