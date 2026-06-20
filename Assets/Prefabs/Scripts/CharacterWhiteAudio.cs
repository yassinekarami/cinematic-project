using UnityEngine;

public class CharacterAudio : MonoBehaviour
{


    public AudioScriptableObject runScriptableAudio;
    public AudioScriptableObject breathingScriptableAudio;

    private float newVolume;

    public AudioSource audioSource;

    public void Start()
    {
        this.audioSource = GetComponent<AudioSource>();
    }
    public void PlayFootstepSound()
    {
        Debug.LogWarning("walkScriptableAudio is not assigned in the inspector.");

    }

    private void FixedUpdate()
    {
        if (this.breathingScriptableAudio.isPlaying(audioSource))
        {
            newVolume = this.breathingScriptableAudio.getNewVolume(audioSource);
            this.breathingScriptableAudio.increaseVolume(audioSource, newVolume);
        }
    }
    public void PlayBreathingSound()
    {
        if (breathingScriptableAudio != null)
        {
            this.breathingScriptableAudio.play(audioSource);
        }
        else
        {
            Debug.LogWarning("breathingScriptableAudio is not assigned in the inspector.");
        }
    }


}
