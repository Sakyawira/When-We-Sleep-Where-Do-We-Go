using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ClipType
{
    IdleLeft,
    IdleRight,
    WalkLeft,
    WalkRight
}

[CreateAssetMenu(menuName = "Data", fileName = "Playable Character Clip Suite")]
public class PlayableCharacterClipSuite : ScriptableObject
{
    [SerializeField]
    private AnimationClip _idleLeft;
    [SerializeField]
    private AnimationClip _idleRight;
    [SerializeField]
    private AnimationClip _walkLeft;
    [SerializeField]
    private AnimationClip _walkRight;
    public  AnimationClip GetClipOfType(ClipType _type)
    {
        switch (_type)
        {
            case ClipType.IdleLeft:
                return _idleLeft;

            case ClipType.IdleRight:
                return _idleRight;

            case ClipType.WalkLeft:
                return _walkLeft;

            case ClipType.WalkRight:
                return _walkRight;
            default:
                return _idleLeft;
        }
    }
}
