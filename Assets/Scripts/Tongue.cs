using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{

    public MousePosition mouse;

    SpringJoint2D sj;
    LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
      sj = GetComponent<SpringJoint2D>();
      line = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0)) {
	      // set end of tongue (us) to where the mouse clicked
        transform.position = mouse.transform.position;
      }

      // just some hacky placeholder way to get giraffe to get off ground
      if (Input.GetMouseButtonDown(1)) {


      }

      // draw a simple line for the tongue
      line.SetPosition(0, sj.connectedBody.transform.position);
      line.SetPosition(1, transform.position);
        
    }
}
