using UnityEngine;
using UnityEngine.Audio;

public class CharacterBlackAudio : MonoBehaviour
{

    public AudioSource walkingAudioSource;

    public void StopWalkingAudioSource()
    {
        walkingAudioSource.Stop();
    }
   
}
