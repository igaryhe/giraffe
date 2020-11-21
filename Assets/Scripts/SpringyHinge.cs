using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringyHinge : MonoBehaviour
{
    private HingeJoint2D joint;
    private JointMotor2D motor;
    public float P_constant = 500f;
    public float D_constant=1f;
    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
        motor = joint.motor;

    }

    void FixedUpdate()
    {
        //Springy joint back to joint angle = 0;
        motor.motorSpeed = -P_constant*joint.jointAngle - D_constant * joint.jointSpeed; 
        joint.motor = motor;
    }
}
