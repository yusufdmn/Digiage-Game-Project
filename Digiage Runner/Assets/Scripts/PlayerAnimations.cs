using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator playerAnimator;
    public bool isRunning;

    void Update()
    {
        isRunning = InputData.Instance.IsRunning();
        if (isRunning)
            playerAnimator.SetBool("run", true);
        else
            playerAnimator.SetBool("run", false);

    }
}