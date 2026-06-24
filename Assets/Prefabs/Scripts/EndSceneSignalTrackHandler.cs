using UnityEngine;
using UnityEngine.UI;

public class EndSceneSignalTrackHandler : MonoBehaviour
{
    public Image endBlackScreen;
    public AudioScriptableObject doorSlammingAudioScriptableObject;
    private AudioSource _selfAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endBlackScreen.enabled = false;
        _selfAudioSource = GetComponent<AudioSource>();
    }

    public void HandleEndSceneSignal()
    {
        if (doorSlammingAudioScriptableObject != null)
        {
            doorSlammingAudioScriptableObject.play(_selfAudioSource);
        }

        endBlackScreen.enabled = true;
    }

    public void StopAllAudioSourceExceptSelf()
    {
        AudioSource[] allSources = FindObjectsByType<AudioSource>(FindObjectsSortMode.None);

        foreach (AudioSource source in allSources)
        {
            if (source != _selfAudioSource)
                source.Stop();
        }
    }

}
