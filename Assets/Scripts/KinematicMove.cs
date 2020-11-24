using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 startPos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = rb.position;
    }
    //Just simple movement to test the joints
    void FixedUpdate()
    {
        rb.MovePosition(startPos + new Vector2(Mathf.Clamp(3f*Mathf.Sin(Time.time*4f),-2f,2f),0));
    }
}
