using UnityEngine;

public class FootstepComponent : MonoBehaviour
{
    public ParticleSystem LeftFootParticles;
    public ParticleSystem RightFootParticles;

    public ParticleSystem BackLeftFootParticles;
    public ParticleSystem BackRightFootParticles;

    void FootstepEvent(int whichFoot)
    {
        Debug.Log("Foot step: " + whichFoot);

        if (whichFoot == 0)
        {
            LeftFootParticles.Play();
        }
        else
        {
            RightFootParticles.Play();
        }
    }


    void BackFootstepEvent(int whichFoot)
    {
        Debug.Log("Foot step: " + whichFoot);

        if (whichFoot == 0)
        {
            BackLeftFootParticles.Play();
        }
        else
        {
            BackRightFootParticles.Play();
        }
    }

}
