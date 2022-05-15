using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _toActivate;

    public void ActivateNextClip()
    {
        _toActivate.SetActive(true);
    }
}