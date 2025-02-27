using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float JumpHeight;
    public float SpeedHorizontal;
    public float DistanceToMaxHeight;
    public float PressTimeToMaxJump;
    public Animator JumpAnimator;

    private Rigidbody2D rigidbody;
    private float jumpStartedTime;
    private int numberOfJumps;
    private SoundManager soundManager;


    private void OnEnable()
    {
        PlayerCollision.OnFloor += SetNumberOfJumps;
        JumpBoost.OnTakeBoost += GetJumpBoost;
    }

    private void OnDisable()
    {
        PlayerCollision.OnFloor -= SetNumberOfJumps;
        JumpBoost.OnTakeBoost -= GetJumpBoost;
    }


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        soundManager = FindAnyObjectByType<SoundManager>();
    }


    void Update()
    {
        JumpAnimator.SetInteger("numberOfJumps", numberOfJumps);
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
            soundManager.SeleccionAudio(2, 0.1f);
        }
    }

    public void OnJumpFinished()
    {
        if (numberOfJumps > 0)
        {
            float fractionOfTimePressed = 1 / Mathf.Clamp01((Time.time - jumpStartedTime) / PressTimeToMaxJump);
            rigidbody.gravityScale *= fractionOfTimePressed;
        }
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

    private void SetNumberOfJumps(int number)
    {
        numberOfJumps = number;
    }

    private void GetJumpBoost()
    {
        var newJumpHeight = JumpHeight;
        JumpHeight += 2;
        SetGravity();
        var vel = new Vector2(rigidbody.linearVelocity.x, GetJumpForce());
        rigidbody.linearVelocity = vel;
        jumpStartedTime = Time.time;
        soundManager.SeleccionAudio(2, 0.1f);
        JumpHeight = newJumpHeight;
    }
}
