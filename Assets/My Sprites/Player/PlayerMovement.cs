using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const string HorizontalAxisName = "Horizontal";
    private const string VerticalAxisName = "Vertical";

    private const string MoveForwardHash = "MoveValue";
    private const string StrafeValueHash = "StrafeValue";

    public float smoothBlend = 0.1f;

    private Animator animator;

    private Vector2 InputDirection;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        InputDirection = new Vector2(Input.GetAxis(HorizontalAxisName), Input.GetAxis(VerticalAxisName));

        if (Input.GetKey(KeyCode.LeftShift)) InputDirection.y += 1;

        animator.SetFloat(MoveForwardHash, InputDirection.y);
        animator.SetFloat(StrafeValueHash, InputDirection.x);
    }

    void Move(float x, float y)
    {
        animator.SetFloat("Blend", y, smoothBlend, Time.deltaTime);

    }
}
