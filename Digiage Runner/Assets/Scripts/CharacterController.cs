using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    Vector3 moveDirection;

    void Update()
    {
        moveDirection = InputData.Instance.GetMoveDirection();
        if(InputData.Instance.IsRunning())
        {
            Move(moveDirection);
            RotateTowardsDirection(moveDirection);
        }
    }


    private void Move(Vector3 givenDirection)
    {
        transform.Translate(moveDirection * (moveSpeed * Time.deltaTime), Space.World);
    }

    private void RotateTowardsDirection(Vector3 givenDirection)
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), rotateSpeed);
    }


}