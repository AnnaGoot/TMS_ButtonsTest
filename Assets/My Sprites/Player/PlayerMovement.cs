using UnityEngine;

[RequireComponent(typeof(Animator), typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{
    private const string HorizontalAxisName = "Horizontal";
    private const string VerticalAxisName = "Vertical";
    private const string MoveForwardHash = "MoveValue";
    private const string StrafeValueHash = "StrafeValue";

    //private const string attackAnimation = "Attack";

    private Animator animator;
    private FloatingJoystick joystick;

    //public float smoothBlend = 0.1f;

    private Vector2 InputDirection;

    //public GameObject weapon;
    //public Sword swordMovement;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        //joystick = GetComponent<FloatingJoystick>();
    }

    private void Update()
    {
        InputDirection = new Vector2(Input.GetAxis(HorizontalAxisName), Input.GetAxis(VerticalAxisName));

        if (Input.GetKey(KeyCode.LeftShift)) InputDirection.y += 1;

        animator.SetFloat(MoveForwardHash, InputDirection.y);
        animator.SetFloat(StrafeValueHash, InputDirection.x);

        //float horizontalInput = joystick.Horizontal;
        //float verticalInput = joystick.Vertical;

        //if (Input.GetKey(KeyCode.LeftShift))
        //verticalInput += 1;

        //animator.SetFloat(MoveForwardHash, verticalInput);
        //animator.SetFloat(StrafeValueHash, horizontalInput);

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    animator.SetTrigger(attackAnimation);
        //}
    }


    //void Move(float x, float y)
    //{
    //    animator.SetFloat("Blend", y, smoothBlend, Time.deltaTime);
    //}

}
