using UnityEngine;

public class CharacterAudio : MonoBehaviour
{


    public AudioScriptableObject runScriptableAudio;
    public AudioScriptableObject breathingScriptableAudio;


    public AudioSource audioSource;

    public void Start()
    {
        this.audioSource = GetComponent<AudioSource>();
    }
    public void OnFootstep()
    {
        Debug.LogWarning("Walk walkScriptableAudio is not assigned in the inspector.");

    }

    public void OnBreathing()
    {
        if (breathingScriptableAudio != null)
        {
            this.breathingScriptableAudio.play(audioSource);
        }
        else
        {
            Debug.LogWarning("Walk breathingScriptableAudio is not assigned in the inspector.");
        }
    }


}
