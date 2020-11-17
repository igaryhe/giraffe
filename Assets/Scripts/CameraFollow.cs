using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // follow the target
      Vector3 targetPos = target.transform.position;
      targetPos.z = -10;
      transform.position = targetPos;
    }
}
