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

    [SerializeField]
    private PlayerMovement _playerMovement;

    void Start()
    {
        _audioSource.clip = _footstep1Clip;
    }

    void LateUpdate()
    {
        if (_playerMovement.IsMovementEnabled())
        {
            if(!_playerMovement.IsLeftMovementEnabled() && Input.GetAxisRaw("Horizontal") < 0)
            {
                return;
            }
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
}
