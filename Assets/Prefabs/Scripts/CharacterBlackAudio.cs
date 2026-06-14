using UnityEngine;
using UnityEngine.Audio;

public class CharacterBlackAudio : MonoBehaviour
{
    public AudioScriptableObject walkScriptableAudio;
    public AudioScriptableObject whisperingScriptableAudio;
    public AudioSource audioSource;
    public void Start()
    {
        this.audioSource = GetComponent<AudioSource>();
    }
    public void OnFootstep()
    {
        if (walkScriptableAudio != null)
        {
            this.walkScriptableAudio.play(audioSource);
        }
        else
        {
            Debug.LogWarning("Walk walkScriptableAudio is not assigned in the inspector.");
        }

    }

    public void OnWhispering()
    {
        if (whisperingScriptableAudio != null)
        {
            this.whisperingScriptableAudio.play(audioSource);
        }
        else
        {
            Debug.LogWarning("Walk whisperingScriptableAudio is not assigned in the inspector.");
        }
    }
}
