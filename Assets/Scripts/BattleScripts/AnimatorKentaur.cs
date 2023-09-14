using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorKentaur : MonoBehaviour
{
    private byte animRobot = 0;

    public Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animRobot = 0;
            RobotWalking();
        }

        if (Input.GetKey(KeyCode.S))
        {
            animRobot = 0;
            RobotWalking();
        }

        if (Input.GetKey(KeyCode.A))
        {
            animRobot = 0;
            RobotWalking();
        }

        if (Input.GetKey(KeyCode.D))
        {
            animRobot = 0;
            RobotWalking();
        }
        if (Input.anyKey == false)
        {
            animRobot = 1;
            RobotWalking();
        }
    }

    void RobotWalking()
    {
        if (animRobot == 1)
        {
            _animator.SetBool("WalkingOn", true);
        }
        else
        {
            if (animRobot == 0)
            {
                _animator.SetBool("WalkingOn", false);
            }
        }
    }
}
