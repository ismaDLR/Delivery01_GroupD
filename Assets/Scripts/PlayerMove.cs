using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Animator Animator;
    [SerializeField]
    private float speed = 5.0f;

    private Rigidbody2D rigidbody;
    private float horizontalDir; // Horizontal move direction value [-1, 1]
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 velocity = rigidbody.linearVelocity;
        Animator.SetFloat("movment", velocity.x * speed);
        if(velocity.x < 0)
        {
            transform.localScale = new Vector3(-5, 5, 5);
        }
        if(velocity.x > 0) 
        { 
            transform.localScale = new Vector3(5, 5, 5);
        }

        velocity.x = horizontalDir * speed;
        rigidbody.linearVelocity = velocity;
    }

    void OnMove(InputValue value)
    {
        var inputVal = value.Get<Vector2>();
        horizontalDir = inputVal.x;
    }
}
