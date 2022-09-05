using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputData : MonoBehaviour
{
    public Joystick joystick;


    private static InputData _instance;       
    public static InputData Instance { get { return _instance; } }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    public Vector3 GetMoveDirection( )
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;
        Vector3 direction = new Vector3(x, 0, z);


        return direction;
    }

    public bool IsRunning()
    {
        if (GetMoveDirection() == Vector3.zero)
            return false;
        else return true;
    }

}
