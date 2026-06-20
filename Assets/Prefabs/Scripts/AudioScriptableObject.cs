using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SocialPlatforms;

[CreateAssetMenu(fileName = "AudioScriptableObject", menuName = "Scriptable Objects/AudioScriptableObject")]
public class AudioScriptableObject : ScriptableObject
{
    public AudioClip audioClip;
    [Range(0.0f, 1.0f)]
    public float volume;
    [Range(0.0f, 1.0f)]
    public float maxVolume;
    [Range(0.0f, 0.5f)]
    public float volumeIncreaseRate;

    private float newVolume;
    public void play(AudioSource audioSource)
    {

        if (audioClip != null)
        {
            this.stop(audioSource);
            audioSource.clip = audioClip;
            audioSource.volume = volume;
            audioSource.Play();
        }
    }

    public void stop(AudioSource audioSource)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    public float getNewVolume(AudioSource audioSource)
    {
        newVolume = audioSource.volume;
        if (newVolume < maxVolume)
        {
            newVolume += Time.deltaTime * volumeIncreaseRate; 
            Debug.Log("Increasing volume: " + newVolume);
        }
        return newVolume;
    }

    public void increaseVolume(AudioSource audioSource, float newVolume)
    {
        audioSource.volume = Mathf.Clamp(newVolume, 0.0f, maxVolume);
    }

    public bool isPlaying(AudioSource audioSource)
    {
        return audioSource != null && audioSource.isPlaying;
    }
}
