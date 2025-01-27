using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static Action<int> OnFloor;
    public static Action<int> OnDie;
    public static Action<int> OnWin;

    private const int numberOfJumps = 2;  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Layer 8 == "Ground"
        if (collision.gameObject.layer == 8)
        {
            OnFloor?.Invoke(numberOfJumps);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OffTheMap")
        {
            OnDie?.Invoke(1);
            SceneManager.LoadScene("Ending");
        }
        else if (collision.gameObject.tag == "Finish")
        {
            OnWin?.Invoke(2);
            SceneManager.LoadScene("Ending");
        }
    }
}
