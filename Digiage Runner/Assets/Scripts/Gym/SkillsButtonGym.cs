using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsButtonGym : MonoBehaviour
{

    [SerializeField] MoveAccurateChecker moveAccurateChecker;
    [SerializeField] Animator gymPlayerAnimator;
    public void GymButton(string animName, moves moveType)
    {
        gymPlayerAnimator.SetTrigger(animName);

    }

}
