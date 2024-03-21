using UnityEngine;


[CreateAssetMenu(menuName = "TMS_ButtonsTest/SoundLibrary")]
public class SoundLibrary : ScriptableObject
{
    [SerializeField] private AudioClip[] footstepsAudioArr;

    public AudioClip GetSound(int index)
    {
        if (index >= 0 && index < footstepsAudioArr.Length)
        {
            return footstepsAudioArr[index];
        }
        else
        {
            Debug.LogWarning("Invalid index for sound!");
            return null;
        }
    }

}
