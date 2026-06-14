using UnityEngine;
using UnityEngine.SocialPlatforms;

[CreateAssetMenu(fileName = "AudioScriptableObject", menuName = "Scriptable Objects/AudioScriptableObject")]
public class AudioScriptableObject : ScriptableObject
{
    public AudioClip audioClip;
    [Range(0.0f, 1.0f)]
    public float volume;

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
}
