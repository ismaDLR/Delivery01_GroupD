using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float JumpHeight;
    public float SpeedHorizontal;
    public float DistanceToMaxHeight;
    public float PressTimeToMaxJump;

    private Rigidbody2D rigidbody;
    private float jumpStartedTime;
    private float numberOfJumps;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnJumpStarted()
    {
        if (numberOfJumps > 0)
        {
            SetGravity();
            var vel = new Vector2(rigidbody.linearVelocity.x, GetJumpForce());
            rigidbody.linearVelocity = vel;
            jumpStartedTime = Time.time;
            numberOfJumps--;
        }
    }

    public void OnJumpFinished()
    {
        float fractionOfTimePressed = 1 / Mathf.Clamp01((Time.time - jumpStartedTime) / PressTimeToMaxJump);
        rigidbody.gravityScale *= fractionOfTimePressed;
    }

    private void SetGravity()
    {
        var grav = 2 * JumpHeight * (SpeedHorizontal * SpeedHorizontal) / (DistanceToMaxHeight * DistanceToMaxHeight);
        rigidbody.gravityScale = grav / 9.81f;
    }

    private float GetJumpForce()
    {
        return 2 * JumpHeight * SpeedHorizontal / DistanceToMaxHeight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Layer 8 == "Ground"
        if (collision.gameObject.layer == 8)
        {
            numberOfJumps = 2;
        }
    }
}
