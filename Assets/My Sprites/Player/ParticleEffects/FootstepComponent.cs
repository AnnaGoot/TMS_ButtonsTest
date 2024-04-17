using UnityEngine;

public class FootstepComponent : MonoBehaviour
{
    public ParticleSystem LeftFootParticles;
    public ParticleSystem RightFootParticles;
    public ParticleSystem BackLeftFootParticles;
    public ParticleSystem BackRightFootParticles;

    private AudioSource audioSource;
    [SerializeField] private SoundLibrary soundLibrary;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void FootstepEvent(int whichFoot)
    {
        Debug.Log("Foot step: " + whichFoot);

        if (whichFoot == 0)
        {
            LeftFootParticles.Play();
            PlayFootstepsSound();
        }
        else
        {
            RightFootParticles.Play();
            PlayFootstepsSound();
        }

    }

    void BackFootstepEvent(int whichFoot)
    {
        Debug.Log("Foot step: " + whichFoot);

        if (whichFoot == 0)
        {
            BackLeftFootParticles.Play();
            PlayFootstepsSound();
        }
        else
        {
            BackRightFootParticles.Play();
            PlayFootstepsSound();
        }

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

}
