using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnClicked : MonoBehaviour
{
    public Animator animator;
    public string animation_name;
    public AudioSource source;
    private void OnMouseDown()
    {
        animator.Play(animation_name);
        source.Play();
    }
}
