using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private AudioSource pressSound;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        StartAnimation();
        if (!pressSound.Equals(null))
        {
            StartSound();
        }
    }

    void StartAnimation()
    {
        anim.SetTrigger("pressed");
    }

    void StartSound()
    {
        if (!pressSound.isPlaying)
        {
            pressSound.Play();
        } else
        {
            pressSound.Stop();
        }
    }
}
