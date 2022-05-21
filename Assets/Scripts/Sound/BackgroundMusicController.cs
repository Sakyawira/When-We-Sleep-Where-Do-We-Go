using UnityEngine;
using System.Collections;

public class BackgroundMusicController : MonoBehaviour
{
    [SerializeField]
    private AudioClip _introMusicClip;
    [SerializeField]
    private AudioClip _loopedMusicClip;
    [SerializeField]
    private AudioSource _introAudioSource;
    [SerializeField]
    private AudioSource _loopedAudioSource;

    private float _duration;

    private void OnEnable()
    {
        _introAudioSource.clip = _introMusicClip;
        _introAudioSource.loop = false;
        _introAudioSource.Play();

        _duration = _introMusicClip.length;

        StartCoroutine(WaitForSound());

        _loopedAudioSource.clip = _loopedMusicClip;
        _loopedAudioSource.loop = true;
    }

    IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(_duration - 3);
        print("FinishAudio");
        _loopedAudioSource.Play();
    }
}