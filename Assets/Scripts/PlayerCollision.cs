using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static Action<int> OnFloor;

    private const int numberOfJumps = 2;
    private Rigidbody2D rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
            SceneManager.LoadScene("Ending", LoadSceneMode.Single);
        }
    }
}
