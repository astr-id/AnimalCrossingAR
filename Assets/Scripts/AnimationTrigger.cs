using UnityEngine;
using System.Collections.Generic;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;

    [System.Serializable]
    public class AnimationSound
    {
        public string animationName;
        public AudioClip sound;
    }

    [System.Serializable]
    public class AnimationVFX
    {
        public string animationName;
        public ParticleSystem particleEffect;
    }

    public List<AnimationSound> animationSounds = new List<AnimationSound>();
    public List<AnimationVFX> animationVFX = new List<AnimationVFX>();

    public void PlayAnimation(string animationName)
    {
        if (animator != null)
            animator.Play(animationName);

        foreach (var animSound in animationSounds)
        {
            if (animSound.animationName == animationName && animSound.sound != null)
            {
                audioSource.PlayOneShot(animSound.sound);
                break;
            }
        }

        foreach (var animVFX in animationVFX)
        {
            if (animVFX.animationName == animationName && animVFX.particleEffect != null)
            {
                animVFX.particleEffect.Play();
                break;
            }
        }
    }
}
