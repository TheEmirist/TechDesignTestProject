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
        if (!pressSound.Equals(null)) //Check if there is a sound attached
        {
            SoundControl();
        }
        CollectItem();
    }

    void StartAnimation()
    {
        anim.SetTrigger("pressed");
    }

    void SoundControl()
    {
        if (!pressSound.isPlaying)
        {
            pressSound.Play();
        } else
        {
            pressSound.Stop();
        }
    }

    void CollectItem()
    {
        if (gameObject.CompareTag("Collectable")) //Destroy object if it is collectable
        {
            Destroy(gameObject, 0.3f);
        }
    }
}
