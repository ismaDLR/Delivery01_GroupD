using UnityEngine;
using UnityEngine.UIElements;

public class PlataformMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.5f;
    [SerializeField]
    private float maxPosition = 1f;
    [SerializeField]
    private float minPosition = -1f;

    private Rigidbody2D rigidbody;
    private float dir = 1; // Horizontal move direction value [-1, 1]
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        if (gameObject.transform.position.x >= maxPosition)
        {
            dir = -1;   
        }
        else if(gameObject.transform.position.x <= minPosition)
        {
            dir = 1;
        }
        
        Vector2 velocity = rigidbody.linearVelocity;
        velocity.x = dir * speed;
        rigidbody.linearVelocity = velocity;
    }
}
