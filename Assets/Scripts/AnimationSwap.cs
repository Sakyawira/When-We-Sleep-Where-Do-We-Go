using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationStage
{
    Original,
    NoGuitar,
    NoHair,
    NoScarf
}

public class AnimationSwap : MonoBehaviour
{
    private Animator _animator;

    [SerializeField]
    private PlayableCharacterClipSuite _originalSuite;
    [SerializeField]
    private PlayableCharacterClipSuite _noGuitarSuite;
    [SerializeField]
    private PlayableCharacterClipSuite _noHairSuite;
    [SerializeField]
    private PlayableCharacterClipSuite _noScarfSuite;

    [SerializeField]
    private AnimationStage _startingSuite;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        Swap(_startingSuite);
    }

    private void Swap(AnimationStage animationStage)
    {
        AnimatorOverrideController aoc = new AnimatorOverrideController(_animator.runtimeAnimatorController);
        var anims = new List<KeyValuePair<AnimationClip, AnimationClip>>();

        PlayableCharacterClipSuite suite = null;

        switch (animationStage)
        {
            case AnimationStage.Original:
                suite = _originalSuite;
                break;
            case AnimationStage.NoGuitar:
                suite = _noGuitarSuite;
                break;
            case AnimationStage.NoHair:
                suite = _noHairSuite;
                break;
            case AnimationStage.NoScarf:
                suite = _noScarfSuite;
                break;
        }

        foreach (var currentClip in aoc.animationClips)
        {
            switch (currentClip.name)
            {
                case nameof(ClipType.IdleLeft):
                    anims.Add(new KeyValuePair<AnimationClip, AnimationClip>(currentClip, suite.GetClipOfType(ClipType.IdleLeft)));
                    break;

                case nameof(ClipType.IdleRight):
                    anims.Add(new KeyValuePair<AnimationClip, AnimationClip>(currentClip, suite.GetClipOfType(ClipType.IdleRight)));
                    break;


                case nameof(ClipType.WalkLeft):
                    anims.Add(new KeyValuePair<AnimationClip, AnimationClip>(currentClip, suite.GetClipOfType(ClipType.WalkLeft)));
                    break;


                case nameof(ClipType.WalkRight):
                    anims.Add(new KeyValuePair<AnimationClip, AnimationClip>(currentClip, suite.GetClipOfType(ClipType.WalkRight)));
                    break;
            }
        }
        aoc.ApplyOverrides(anims);
        _animator.runtimeAnimatorController = aoc;
    }

    public void SwapToNoScarf()
    {
        Swap(AnimationStage.NoScarf);
    }

    public void SwapToNoHair()
    {
        Swap(AnimationStage.NoHair);
    }

    public void SwapToNoGuitar()
    {
        Swap(AnimationStage.NoGuitar);
    }
}
