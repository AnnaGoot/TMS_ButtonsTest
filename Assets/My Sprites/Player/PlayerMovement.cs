using UnityEngine;

[RequireComponent(typeof(Animator), typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{
    private const string HorizontalAxisName = "Horizontal";
    private const string VerticalAxisName = "Vertical";
    private const string MoveForwardHash = "MoveValue";
    private const string StrafeValueHash = "StrafeValue";

    private const string attackAnimation = "Attack";

    private AudioSource audioSource;
    [SerializeField] private SoundLibrary soundLibrary;
    private Animator animator;

    public float smoothBlend = 0.1f;

    private Vector2 InputDirection;

    public GameObject weapon;
    public Sword swordMovement;

    private bool isMoving = false;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        InputDirection = new Vector2(Input.GetAxis(HorizontalAxisName), Input.GetAxis(VerticalAxisName));

        if (Input.GetKey(KeyCode.LeftShift)) InputDirection.y += 1;

        animator.SetFloat(MoveForwardHash, InputDirection.y);
        animator.SetFloat(StrafeValueHash, InputDirection.x);

        if (InputDirection.magnitude > 0)
        {
            if (!isMoving)
            {
                isMoving = true;
                PlayFootstepsSound();
            }
        }
        else
        {
            if (isMoving)
            {
                isMoving = false;
                StopFootstepsSound();
            }
            
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (!audioSource.isPlaying)
            {
                PlayRunningSound();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                StopRunningSound();
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger(attackAnimation);
        }
    }


    void Move(float x, float y)
    {
        animator.SetFloat("Blend", y, smoothBlend, Time.deltaTime);
    }

    void PlayFootstepsSound()
    {
        AudioClip footstepsSound = soundLibrary.GetSound(0);
        if (footstepsSound != null)
        {
            audioSource.clip = footstepsSound;
            audioSource.Play();
        }
    }

    void StopFootstepsSound()
    {
        audioSource.Stop();
    }


    void PlayRunningSound()
    {
        AudioClip runningSound = soundLibrary.GetSound(1);
        if (runningSound != null)
        {
            audioSource.clip = runningSound;
            audioSource.Play();
        }
    }

    void StopRunningSound()
    {
        audioSource.Stop();
    }
}
