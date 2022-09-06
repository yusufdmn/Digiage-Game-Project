using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    Vector3 moveDirection;

    private Camera camera;
    private float currentAngle;
    private float currentAngleVelocity;
    private const float rotationSmoothTime = 0.15f;
    private void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        moveDirection = InputData.Instance.GetMoveDirection();
        if(InputData.Instance.IsRunning())
        {
            var targetRotation = Quaternion.LookRotation(moveDirection);
            var targetAngle = targetRotation.eulerAngles.y;
            targetAngle += camera.transform.eulerAngles.y;

            currentAngle = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref currentAngleVelocity, rotationSmoothTime);

            transform.eulerAngles = new Vector3(0, currentAngle, 0);

            transform.Translate(transform.forward * moveSpeed * Time.deltaTime, Space.World);
            //transform.Translate()

            //Move(moveDirection);
            //RotateTowardsDirection(moveDirection);
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