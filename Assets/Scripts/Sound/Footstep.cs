using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    [SerializeField]
    private AudioClip _footstep1Clip;

    [SerializeField]
    private AudioClip _footstep2Clip;

    [SerializeField]
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource.clip = _footstep1Clip;
        // _audioSource.loop = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            if (!_audioSource.isPlaying)
            {
                //if (Random.Range(0, 2) == 0)
                //{
                //    if (_audioSource.clip == _footstep1Clip)
                //    {
                //        _audioSource.clip = _footstep2Clip;

                //    }
                //    else
                //    {
                //        _audioSource.clip = _footstep1Clip;
                //    }
                //}
                _audioSource.Play();
            }
        }
    }
}
