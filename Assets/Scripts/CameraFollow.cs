using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public Transform upperLimit;
    public Transform lowerLimit;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
      cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
      // follow the target
      Vector3 targetPos = target.transform.position;

      // keep camera at a distance
      targetPos.z = -10;

      // don't let camera go too high or too low

      // this is the camera's orthogrpahic half-size
      float size = cam.orthographicSize;
      targetPos.y = Mathf.Clamp(targetPos.y,
                               upperLimit.position.y + size,
                               lowerLimit.position.y - size);




      transform.position = targetPos;
    }

    void OnDrawGizmosSelected() {
//       Gizmos.color = Color.blue;
// 
// 
//       // draw upper limit line
//       Gizmos.DrawLine(upperLimit.position., );
// 
// 
//       // draw lower limit line
//       Gizmos.DrawLine( , );
// 
// 
    }
}
