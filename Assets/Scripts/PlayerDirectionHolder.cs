using UnityEngine;
using AC;

public class PlayerDirectionHolder : MonoBehaviour
{
    private Animator animator;
    public float lastAngle = 0f;
    public bool wasMoving = false, IsMoving = false;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (KickStarter.player == null) return;

        IsMoving = KickStarter.player.GetMoveSpeed() > 0.1f;

        if (IsMoving)
        {
            // Store the current angle while moving
            lastAngle = animator.GetFloat("Angle");
            wasMoving = true;
        }
        else if (wasMoving && !IsMoving)
        {
            // Player just stopped — set directional idle
            SetDirectionalIdle(lastAngle);
            wasMoving = false;
        }
    }

    void SetDirectionalIdle(float angle)
    {
        if (angle >= 337.5f || angle < 22.5f) animator.Play("Idle_D");
        else if (angle >= 22.5f && angle < 67.5f) animator.Play("Idle_DR");
        else if (angle >= 67.5f && angle < 112.5f) animator.Play("Idle_R");
        else if (angle >= 112.5f && angle < 157.5f) animator.Play("Idle_UR");
        else if (angle >= 157.5f && angle < 202.5f) animator.Play("Idle_U");
        else if (angle >= 202.5f && angle < 247.5f) animator.Play("Idle_UL");
        else if (angle >= 247.5f && angle < 292.5f) animator.Play("Idle_L");
        else if (angle >= 292.5f && angle < 337.5f) animator.Play("Idle_DL");
    }
}