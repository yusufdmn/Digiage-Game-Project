using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsButton : MonoBehaviour
{
    public Animator animator;
    public void PlayTriggerAnim(string name)
    {
        Debug.Log(name);
        animator.SetTrigger(name);
    }
}