using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClicked : MonoBehaviour
{
    public Animator animator;
    public string animation_name;

    private void OnMouseDown()
    {
        animator.Play(animation_name);
    }
}
