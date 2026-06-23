using UnityEngine;
using UnityEngine.UI;

public class EndSceneSignalTrackHandler : MonoBehaviour
{
    public Image endBlackScreen;
    public AudioScriptableObject doorSlammingAudioScriptableObject;
    private AudioSource audioSource;
    public AudioListener audioListener;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endBlackScreen.enabled = false;
        audioSource = GetComponent<AudioSource>();
    }

    public void HandleEndSceneSignal()
    {
        if (doorSlammingAudioScriptableObject != null)
        {
            doorSlammingAudioScriptableObject.play(audioSource);
        }

        endBlackScreen.enabled = true;
        audioListener.enabled = false;
    }

}
