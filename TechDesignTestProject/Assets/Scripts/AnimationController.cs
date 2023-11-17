using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update

    void OnMouseDown()
    {
        anim.SetTrigger("pressed");
    }
}
