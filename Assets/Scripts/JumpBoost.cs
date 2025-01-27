using System;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    public static Action OnTakeBoost;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnTakeBoost?.Invoke();
        }
    }
}
